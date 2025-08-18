using CsvHelper.Configuration.Attributes;

namespace Charybdis.Core.Entities.DTOs
{
    public class GIASDataModel
    {
        [Name("URN")]
        public string URN { get; set; }
        [Name("LA (code)")]
        public string LAcode { get; set; }
        [Name("LA (name)")]
        public string LAname { get; set; }
        [Name("EstablishmentNumber")]
        public string EstablishmentNumber { get; set; }
        [Name("EstablishmentName")]
        public string EstablishmentName { get; set; }
        [Name("TypeOfEstablishment (code)")]
        public string TypeOfEstablishmentcode { get; set; }
        [Name("TypeOfEstablishment (name)")]
        public string TypeOfEstablishmentname { get; set; }
        [Name("EstablishmentTypeGroup (code)")]
        public string EstablishmentTypeGroupcode { get; set; }
        [Name("EstablishmentTypeGroup (name)")]
        public string EstablishmentTypeGroupname { get; set; }
        [Name("EstablishmentStatus (code)")]
        public string EstablishmentStatuscode { get; set; }
        [Name("EstablishmentStatus (name)")]
        public string EstablishmentStatusname { get; set; }
        [Name("ReasonEstablishmentOpened (code)")]
        public string ReasonEstablishmentOpenedcode { get; set; }
        [Name("ReasonEstablishmentOpened (name)")]
        public string ReasonEstablishmentOpenedname { get; set; }
        [Name("OpenDate")]
        public string OpenDate { get; set; }
        [Name("ReasonEstablishmentClosed (code)")]
        public string ReasonEstablishmentClosedcode { get; set; }
        [Name("ReasonEstablishmentClosed (name)")]
        public string ReasonEstablishmentClosedname { get; set; }
        [Name("CloseDate")]
        public string CloseDate { get; set; }
        [Name("PhaseOfEducation (code)")]
        public string PhaseOfEducationcode { get; set; }
        [Name("PhaseOfEducation (name)")]
        public string PhaseOfEducationname { get; set; }
        [Name("StatutoryLowAge")]
        public string StatutoryLowAge { get; set; }
        [Name("StatutoryHighAge")]
        public string StatutoryHighAge { get; set; }
        [Name("Boarders (code)")]
        public string Boarderscode { get; set; }
        [Name("Boarders (name)")]
        public string Boardersname { get; set; }
        [Name("NurseryProvision (name)")]
        public string NurseryProvisionname { get; set; }
        [Name("OfficialSixthForm (code)")]
        public string OfficialSixthFormcode { get; set; }
        [Name("OfficialSixthForm (name)")]
        public string OfficialSixthFormname { get; set; }
        [Name("Gender (code)")]
        public string Gendercode { get; set; }
        [Name("Gender (name)")]
        public string Gendername { get; set; }
        [Name("ReligiousCharacter (code)")]
        public string ReligiousCharactercode { get; set; }
        [Name("ReligiousCharacter (name)")]
        public string ReligiousCharactername { get; set; }
        [Name("ReligiousEthos (name)")]
        public string ReligiousEthosname { get; set; }
        [Name("Diocese (code)")]
        public string Diocesecode { get; set; }
        [Name("Diocese (name)")]
        public string Diocesename { get; set; }
        [Name("AdmissionsPolicy (code)")]
        public string AdmissionsPolicycode { get; set; }
        [Name("AdmissionsPolicy (name)")]
        public string AdmissionsPolicyname { get; set; }
        [Name("SchoolCapacity")]
        public string SchoolCapacity { get; set; }
        [Name("SpecialClasses (code)")]
        public string SpecialClassescode { get; set; }
        [Name("SpecialClasses (name)")]
        public string SpecialClassesname { get; set; }
        [Name("CensusDate")]
        public string CensusDate { get; set; }
        [Name("NumberOfPupils")]
        public string NumberOfPupils { get; set; }
        [Name("NumberOfBoys")]
        public string NumberOfBoys { get; set; }
        [Name("NumberOfGirls")]
        public string NumberOfGirls { get; set; }
        [Name("PercentageFSM")]
        public string PercentageFSM { get; set; }
        [Name("TrustSchoolFlag (code)")]
        public string TrustSchoolFlagcode { get; set; }
        [Name("TrustSchoolFlag (name)")]
        public string TrustSchoolFlagname { get; set; }
        [Name("Trusts (code)")]
        public string Trustscode { get; set; }
        [Name("Trusts (name)")]
        public string Trustsname { get; set; }
        [Name("SchoolSponsorFlag (name)")]
        public string SchoolSponsorFlagname { get; set; }
        [Name("SchoolSponsors (name)")]
        public string SchoolSponsorsname { get; set; }
        [Name("FederationFlag (name)")]
        public string FederationFlagname { get; set; }
        [Name("Federations (code)")]
        public string Federationscode { get; set; }
        [Name("Federations (name)")]
        public string Federationsname { get; set; }
        [Name("UKPRN")]
        public string UKPRN { get; set; }
        [Name("FEHEIdentifier")]
        public string FEHEIdentifier { get; set; }
        [Name("FurtherEducationType (name)")]
        public string FurtherEducationTypename { get; set; }
        [Name("LastChangedDate")]
        public string LastChangedDate { get; set; }
        [Name("Street")]
        public string Street { get; set; }
        [Name("Locality")]
        public string Locality { get; set; }
        [Name("Address3")]
        public string Address3 { get; set; }
        [Name("Town")]
        public string Town { get; set; }
        [Name("County (name)")]
        public string Countyname { get; set; }
        [Name("Postcode")]
        public string Postcode { get; set; }
        [Name("SchoolWebsite")]
        public string SchoolWebsite { get; set; }
        [Name("TelephoneNum")]
        public string TelephoneNum { get; set; }
        [Name("HeadTitle (name)")]
        public string HeadTitlename { get; set; }
        [Name("HeadFirstName")]
        public string HeadFirstName { get; set; }
        [Name("HeadLastName")]
        public string HeadLastName { get; set; }
        [Name("HeadPreferredJobTitle")]
        public string HeadPreferredJobTitle { get; set; }
        [Name("BSOInspectorateName (name)")]
        public string BSOInspectorateNamename { get; set; }
        [Name("InspectorateReport")]
        public string InspectorateReport { get; set; }
        [Name("DateOfLastInspectionVisit")]
        public string DateOfLastInspectionVisit { get; set; }
        [Name("NextInspectionVisit")]
        public string NextInspectionVisit { get; set; }
        [Name("TeenMoth (name)")]
        public string TeenMothname { get; set; }
        [Name("TeenMothPlaces")]
        public string TeenMothPlaces { get; set; }
        [Name("CCF (name)")]
        public string CCFname { get; set; }
        [Name("SENPRU (name)")]
        public string SENPRUname { get; set; }
        [Name("EBD (name)")]
        public string EBDname { get; set; }
        [Name("PlacesPRU")]
        public string PlacesPRU { get; set; }
        [Name("FTProv (name)")]
        public string FTProvname { get; set; }
        [Name("EdByOther (name)")]
        public string EdByOthername { get; set; }
        [Name("Section41Approved (name)")]
        public string Section41Approvedname { get; set; }
        [Name("SEN1 (name)")]
        public string SEN1name { get; set; }
        [Name("SEN2 (name)")]
        public string SEN2name { get; set; }
        [Name("SEN3 (name)")]
        public string SEN3name { get; set; }
        [Name("SEN4 (name)")]
        public string SEN4name { get; set; }
        [Name("SEN5 (name)")]
        public string SEN5name { get; set; }
        [Name("SEN6 (name)")]
        public string SEN6name { get; set; }
        [Name("SEN7 (name)")]
        public string SEN7name { get; set; }
        [Name("SEN8 (name)")]
        public string SEN8name { get; set; }
        [Name("SEN9 (name)")]
        public string SEN9name { get; set; }
        [Name("SEN10 (name)")]
        public string SEN10name { get; set; }
        [Name("SEN11 (name)")]
        public string SEN11name { get; set; }
        [Name("SEN12 (name)")]
        public string SEN12name { get; set; }
        [Name("SEN13 (name)")]
        public string SEN13name { get; set; }
        [Name("TypeOfResourcedProvision (name)")]
        public string TypeOfResourcedProvisionname { get; set; }
        [Name("ResourcedProvisionOnRoll")]
        public string ResourcedProvisionOnRoll { get; set; }
        [Name("ResourcedProvisionCapacity")]
        public string ResourcedProvisionCapacity { get; set; }
        [Name("SenUnitOnRoll")]
        public string SenUnitOnRoll { get; set; }
        [Name("SenUnitCapacity")]
        public string SenUnitCapacity { get; set; }
        [Name("GOR (code)")]
        public string GORcode { get; set; }
        [Name("GOR (name)")]
        public string GORname { get; set; }
        [Name("DistrictAdministrative (code)")]
        public string DistrictAdministrativecode { get; set; }
        [Name("DistrictAdministrative (name)")]
        public string DistrictAdministrativename { get; set; }
        [Name("AdministrativeWard (code)")]
        public string AdministrativeWardcode { get; set; }
        [Name("AdministrativeWard (name)")]
        public string AdministrativeWardname { get; set; }
        [Name("ParliamentaryConstituency (code)")]
        public string ParliamentaryConstituencycode { get; set; }
        [Name("ParliamentaryConstituency (name)")]
        public string ParliamentaryConstituencyname { get; set; }
        [Name("UrbanRural (code)")]
        public string UrbanRuralcode { get; set; }
        [Name("UrbanRural (name)")]
        public string UrbanRuralname { get; set; }
        [Name("GSSLACode (name)")]
        public string GSSLACodename { get; set; }
        [Name("Easting")]
        public string Easting { get; set; }
        [Name("Northing")]
        public string Northing { get; set; }
        [Name("MSOA (name)")]
        public string MSOAname { get; set; }
        [Name("LSOA (name)")]
        public string LSOAname { get; set; }
        [Name("InspectorateName (name)")]
        public string InspectorateNamename { get; set; }
        [Name("SENStat")]
        public string SENStat { get; set; }
        [Name("SENNoStat")]
        public string SENNoStat { get; set; }
        [Name("BoardingEstablishment (name)")]
        public string BoardingEstablishmentname { get; set; }
        [Name("PropsName")]
        public string PropsName { get; set; }
        [Name("PreviousLA (code)")]
        public string PreviousLAcode { get; set; }
        [Name("PreviousLA (name)")]
        public string PreviousLAname { get; set; }
        [Name("PreviousEstablishmentNumber")]
        public string PreviousEstablishmentNumber { get; set; }
        [Name("Country (name)")]
        public string Countryname { get; set; }
        [Name("UPRN")]
        public string UPRN { get; set; }
        [Name("SiteName")]
        public string SiteName { get; set; }
        [Name("QABName (code)")]
        public string QABNamecode { get; set; }
        [Name("QABName (name)")]
        public string QABNamename { get; set; }
        [Name("EstablishmentAccredited (code)")]
        public string EstablishmentAccreditedcode { get; set; }
        [Name("EstablishmentAccredited (name)")]
        public string EstablishmentAccreditedname { get; set; }
        [Name("QABReport")]
        public string QABReport { get; set; }
        [Name("CHNumber")]
        public string CHNumber { get; set; }
        [Name("MSOA (code)")]
        public string MSOAcode { get; set; }
        [Name("LSOA (code)")]
        public string LSOAcode { get; set; }
        [Name("FSM")]
        public string FSM { get; set; }
        [Name("AccreditationExpiryDate")]
        public string AccreditationExpiryDate { get; set; }

    }
}

