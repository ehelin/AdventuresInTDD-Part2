using System.Web.Mvc;
using AdventuresInTDD_Part2.Models;
using Shared;
using Shared.interfaces;
using AdventuresInTDD_Part2.Helper;
using System;
using Sequence;
using Sort;

namespace AdventuresInTDD_Part2.Controllers
{
    public class HomeController : Controller
    {
        //tODO - add autofac and moq to tdd project
        private Utilities utils;
        private IConversionHelper conversionHelper;
        private ISort sort;
        private ISequence sequence;

        public HomeController()
        {
            utils = new Utilities();
            conversionHelper = new ConversionHelper();
            sort = new SortImpl();
            sequence = new SequenceImpl();
        }

        public ActionResult Index()
        {
            Utilities utils = new Utilities();
            var results = utils.GetConversionOptions();

            return View();
        }
        
        public ViewResult Conversion()
        {
            ConversionModel model = new ConversionModel();

            model.ConversionOptionsFrom = utils.GetConversionOptions();
            model.SelectedConversionOptionFrom = model.ConversionOptionsFrom[0];

            model.ConversionOptionsTo = utils.GetConversionOptions();
            model.SelectedConversionOptionTo = model.ConversionOptionsTo[0];

            return View(model);
        }

        public ViewResult ConversionResult(ConversionModel model)
        {
            ConversionResultModel resultModel = new ConversionResultModel();

            Enumeration.SupportedDataTypes selectedFrom = (Enumeration.SupportedDataTypes)Enum.Parse(typeof(Enumeration.SupportedDataTypes), model.SelectedConversionOptionFrom, true);
            Enumeration.SupportedDataTypes selectedTo = (Enumeration.SupportedDataTypes)Enum.Parse(typeof(Enumeration.SupportedDataTypes), model.SelectedConversionOptionTo, true);

            resultModel.ConvertedValue = conversionHelper.ConvertValue(selectedFrom, selectedTo, model.InputValue);
            
            return View(resultModel);
        }

        public ViewResult Sequence()
        {
            SequenceModel model = new SequenceModel();

            model.SequenceDataTypes = utils.GetConversionOptions();
            model.SelectedSequenceDataType = model.SequenceDataTypes[0];

            model.SequenceIncrementOptions = utils.GetIncrementOptions();
            model.SelectedSequenceIncrement = model.SequenceIncrementOptions[0];

            return View(model);
        }

        public ViewResult SequenceResults(SequenceModel model)
        {
            SequenceResultModel resultModel = new SequenceResultModel();

            Enumeration.SupportedDataTypes sequenceDataType = (Enumeration.SupportedDataTypes)Enum.Parse(typeof(Enumeration.SupportedDataTypes), model.SelectedSequenceDataType, true);
            Enumeration.SupportedIncrements incrementValue = (Enumeration.SupportedIncrements)Enum.Parse(typeof(Enumeration.SupportedIncrements), model.SelectedSequenceIncrement, true);

            resultModel.Sequence = sequence.CreateSequence(model.InputValue, sequenceDataType, incrementValue);

            if (model.SortAscending)
                resultModel.Sequence = sort.SortAscending(resultModel.Sequence, sequenceDataType);
            else if (model.SortDescending)
                resultModel.Sequence = sort.SortDescending(resultModel.Sequence, sequenceDataType);

            return View(resultModel);
        }
    }
}