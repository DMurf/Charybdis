using Charybdis.Core.Entities.Measures.CrossCutting;
using Charybdis.Core.Entities.Measures.KS4;
using Charybdis.Core.Interfaces.Services;
using Charybdis.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Charybdis.Web.Controllers
{
    public class SchoolController : Controller
    {
        private readonly IEstablishmentMetadataService _establishmentMetadataService;

        public SchoolController(IEstablishmentMetadataService EstablishmentMetadataService)
        {
            _establishmentMetadataService = EstablishmentMetadataService;
        }

        [Route("school/{urn}")]
        public IActionResult IndexRedirect(int urn)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            if (establishment !=null)
            {
                ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
                ViewBag.EstabNumber = establishment.EstablishmentNumber;
                return RedirectToAction("AboutTheSchool", new { @urn = establishment.EstablishmentNumber, @name = establishment.EstablishmentNameUrlFriendly });
            }
            return View("Error");
        }

        [Route("school/{urn}/{name}/about")]
        public IActionResult AboutTheSchool(int urn, string name)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(establishment);
        }

        [Route("school/{urn}/{name}/admissions")]
        public IActionResult Admissions(int urn, string name)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(establishment);
        }

        [Route("school/{urn}/{name}/curriculum")]
        public IActionResult CurriculumEnrichment(int urn, string name)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(establishment);
        }

        [Route("school/{urn}/{name}/attendance")]
        public IActionResult Attendance(int urn, string name)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(establishment);
        }

        [Route("school/{urn}/{name}/academicperformance")]
        public IActionResult AcademicPerformance(int urn, string name, string? tab)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            var viewModel = new AcademicPerformanceViewModel
            {
                EstablishmentMetadata = establishment
            };

            viewModel.KS4_Grade5EngMath = new Grade5EngMath
            {
                Grade5_EngMaths = "0.612",
                Grade5_EngMaths_YPrevious = "0.35",
                Grade5_EngMaths_YPrevious2 = "0.26",
                Grade5_EngMaths_Boys = "0.5",
                Grade5_EngMaths_DisAdv = "0.4",
                Grade5_EngMaths_EAL = "0.3",
                Grade5_EngMaths_Girls = "0.6",
                Grade5_EngMaths_LA = "0.56",
                Grade5_EngMaths_LA_YPrevious2 = "0.53",
                Grade5_EngMaths_LA_YPrevious = "0.50",
                Grade5_EngMaths_NAT = "0.40",
                Grade5_EngMaths_NAT_YPrevious2 = "0.45",
                Grade5_EngMaths_NAT_YPrevious = "0.46",
                Grade5_EngMaths_Boys_LA = "0.41",
                Grade5_EngMaths_Boys_NAT = "0.42",
                Grade5_EngMaths_DisAdv_LA = "0.43",
                Grade5_EngMaths_DisAdv_NAT = "0.44",
                Grade5_EngMaths_EAL_LA = "0.45",
                Grade5_EngMaths_EAL_NAT = "0.46",
                Grade5_EngMaths_Girls_LA = "0.47",
                Grade5_EngMaths_Girls_NAT = "0.48",
            };

            viewModel.KS4_Grade5EngMath.VisualMeasure = new Core.Entities.VisualMeasure
            {
                ROTId = "KS4-engmatROT",
                ChartId = "KS4-engmatchart",
                TableId = "KS4-table",
                ChartDataValues = new[] { viewModel.KS4_Grade5EngMath.Grade5_EngMaths, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_LA, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_NAT },
                ChartTableLabels = new[] { "School", establishment.LocalAuthorityName + " average", "England average" },
                ShowROT = true,
                ShowChart = true,
                ROTDataTableLabels = new[] { "School", establishment.LocalAuthorityName + " average", "England average" },
                ROTDataValuesY1 = new[] { viewModel.KS4_Grade5EngMath.Grade5_EngMaths, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_LA, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_NAT },
                ROTDataValuesY2 = new[] { viewModel.KS4_Grade5EngMath.Grade5_EngMaths_YPrevious, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_LA_YPrevious, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_NAT_YPrevious },
                ROTDataValuesY3 = new[] { viewModel.KS4_Grade5EngMath.Grade5_EngMaths_YPrevious2, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_LA_YPrevious2, viewModel.KS4_Grade5EngMath.Grade5_EngMaths_NAT_YPrevious2 },

            };

            viewModel.KS4_SubjectEntries = new SubjectEntries
            {
                CoreSubjects = new List<SubjectEntryItem>
                {
                    new SubjectEntryItem("English language", "GCSE", 160),
                    new SubjectEntryItem("English literature", "GCSE", 140),
                    new SubjectEntryItem("Mathematics", "GCSE", 200),
                    new SubjectEntryItem("Science: Double award", "GCSE", 150),
                    new SubjectEntryItem("Biology", "GCSE", 99),
                    new SubjectEntryItem("Chemistry", "GCSE", 90),
                    new SubjectEntryItem("Physics", "GCSE", 70),
                },
                AdditionalSubjects = new List<SubjectEntryItem>
                {
                    new SubjectEntryItem("Animal Care", "Technical award", 30),
                    new SubjectEntryItem("Art and design", "GCSE", 20),
                    new SubjectEntryItem("Computer studies", "GCSE", 60),
                    new SubjectEntryItem("Construction", "Technical award", 3),
                },
            };

            viewModel.KS4_Destinations = new Destinations
            {
                Destination_School = "0.95",
                Destination_LA = "0.90",
                Destination_NAT = "0.92",
                Destination_Education = "0.75",
                Destination_Education_LA = "0.80",
                Destination_Education_NAT = "0.95",
                Destination_Apprenticeships = "0.60",
                Destination_Apprenticeships_LA = "0.61",
                Destination_Apprenticeships_NAT = "0.62",
                Destination_Employment = "0.71",
                Destination_Employment_LA = "0.72",
                Destination_Employment_NAT = "0.73",
            };

            viewModel.KS4_Destinations.VisualMeasure = new Core.Entities.VisualMeasure
            {
                ChartDataValues = new[] { viewModel.KS4_Destinations.Destination_School, viewModel.KS4_Destinations.Destination_LA, viewModel.KS4_Destinations.Destination_NAT },
                ChartId = "destination",
                ShowChart = true,
                ShowROT = false,
                ChartTableLabels = new[] { "School", $"{establishment.LocalAuthorityName} average","England average" },
                TableId = "table"
            };













            ViewBag.Tab = tab;
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(viewModel);
        }


        [Route("school/{urn}/{name}/ofsted")]
        public IActionResult Ofsted(int urn, string name)
        {
            var establishment = _establishmentMetadataService.GetEstablishment(urn);
            ViewBag.EstabNameSafe = establishment.EstablishmentNameUrlFriendly;
            ViewBag.EstabNumber = establishment.EstablishmentNumber;
            return View(establishment);
        }
    }
}
