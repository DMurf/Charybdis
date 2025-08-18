using CsvHelper.Configuration.Attributes;

namespace Charybdis.Core.Entities.DTOs
{
    public class GIASDataModel
    {
        [Name("URN")]
        public string URN {get; set; } = default!;
        [Name("LA (code)")]
        public string LAcode {get; set; } = default!;
        [Name("LA (name)")]
        public string LAname {get; set; } = default!;
        [Name("EstablishmentNumber")]
        public string EstablishmentNumber {get; set; } = default!;
        [Name("EstablishmentName")]
        public string EstablishmentName {get; set; } = default!;
        [Name("TypeOfEstablishment (code)")]
        public string TypeOfEstablishmentcode {get; set; } = default!;
        [Name("TypeOfEstablishment (name)")]
        public string TypeOfEstablishmentname {get; set; } = default!;
        [Name("EstablishmentTypeGroup (code)")]
        public string EstablishmentTypeGroupcode {get; set; } = default!;
        [Name("EstablishmentTypeGroup (name)")]
        public string EstablishmentTypeGroupname {get; set; } = default!;
        [Name("EstablishmentStatus (code)")]
        public string EstablishmentStatuscode {get; set; } = default!;
        [Name("EstablishmentStatus (name)")]
        public string EstablishmentStatusname {get; set; } = default!;
        [Name("ReasonEstablishmentOpened (code)")]
        public string ReasonEstablishmentOpenedcode {get; set; } = default!;
        [Name("ReasonEstablishmentOpened (name)")]
        public string ReasonEstablishmentOpenedname {get; set; } = default!;
        [Name("OpenDate")]
        public string OpenDate {get; set; } = default!;
        [Name("ReasonEstablishmentClosed (code)")]
        public string ReasonEstablishmentClosedcode {get; set; } = default!;
        [Name("ReasonEstablishmentClosed (name)")]
        public string ReasonEstablishmentClosedname {get; set; } = default!;
        [Name("CloseDate")]
        public string CloseDate {get; set; } = default!;
        [Name("PhaseOfEducation (code)")]
        public string PhaseOfEducationcode {get; set; } = default!;
        [Name("PhaseOfEducation (name)")]
        public string PhaseOfEducationname {get; set; } = default!;
        [Name("StatutoryLowAge")]
        public string StatutoryLowAge {get; set; } = default!;
        [Name("StatutoryHighAge")]
        public string StatutoryHighAge {get; set; } = default!;
        [Name("Boarders (code)")]
        public string Boarderscode {get; set; } = default!;
        [Name("Boarders (name)")]
        public string Boardersname {get; set; } = default!;
        [Name("NurseryProvision (name)")]
        public string NurseryProvisionname {get; set; } = default!;
        [Name("OfficialSixthForm (code)")]
        public string OfficialSixthFormcode {get; set; } = default!;
        [Name("OfficialSixthForm (name)")]
        public string OfficialSixthFormname {get; set; } = default!;
        [Name("Gender (code)")]
        public string Gendercode {get; set; } = default!;
        [Name("Gender (name)")]
        public string Gendername {get; set; } = default!;
        [Name("ReligiousCharacter (code)")]
        public string ReligiousCharactercode {get; set; } = default!;
        [Name("ReligiousCharacter (name)")]
        public string ReligiousCharactername {get; set; } = default!;
        [Name("ReligiousEthos (name)")]
        public string ReligiousEthosname {get; set; } = default!;
        [Name("Diocese (code)")]
        public string Diocesecode {get; set; } = default!;
        [Name("Diocese (name)")]
        public string Diocesename {get; set; } = default!;
        [Name("AdmissionsPolicy (code)")]
        public string AdmissionsPolicycode {get; set; } = default!;
        [Name("AdmissionsPolicy (name)")]
        public string AdmissionsPolicyname {get; set; } = default!;
        [Name("SchoolCapacity")]
        public string SchoolCapacity {get; set; } = default!;
        [Name("SpecialClasses (code)")]
        public string SpecialClassescode {get; set; } = default!;
        [Name("SpecialClasses (name)")]
        public string SpecialClassesname {get; set; } = default!;
        [Name("CensusDate")]
        public string CensusDate {get; set; } = default!;
        [Name("NumberOfPupils")]
        public string NumberOfPupils {get; set; } = default!;
        [Name("NumberOfBoys")]
        public string NumberOfBoys {get; set; } = default!;
        [Name("NumberOfGirls")]
        public string NumberOfGirls {get; set; } = default!;
        [Name("PercentageFSM")]
        public string PercentageFSM {get; set; } = default!;
        [Name("TrustSchoolFlag (code)")]
        public string TrustSchoolFlagcode {get; set; } = default!;
        [Name("TrustSchoolFlag (name)")]
        public string TrustSchoolFlagname {get; set; } = default!;
        [Name("Trusts (code)")]
        public string Trustscode {get; set; } = default!;
        [Name("Trusts (name)")]
        public string Trustsname {get; set; } = default!;
        [Name("SchoolSponsorFlag (name)")]
        public string SchoolSponsorFlagname {get; set; } = default!;
        [Name("SchoolSponsors (name)")]
        public string SchoolSponsorsname {get; set; } = default!;
        [Name("FederationFlag (name)")]
        public string FederationFlagname {get; set; } = default!;
        [Name("Federations (code)")]
        public string Federationscode {get; set; } = default!;
        [Name("Federations (name)")]
        public string Federationsname {get; set; } = default!;
        [Name("UKPRN")]
        public string UKPRN {get; set; } = default!;
        [Name("FEHEIdentifier")]
        public string FEHEIdentifier {get; set; } = default!;
        [Name("FurtherEducationType (name)")]
        public string FurtherEducationTypename {get; set; } = default!;
        [Name("LastChangedDate")]
        public string LastChangedDate {get; set; } = default!;
        [Name("Street")]
        public string Street {get; set; } = default!;
        [Name("Locality")]
        public string Locality {get; set; } = default!;
        [Name("Address3")]
        public string Address3 {get; set; } = default!;
        [Name("Town")]
        public string Town {get; set; } = default!;
        [Name("County (name)")]
        public string Countyname {get; set; } = default!;
        [Name("Postcode")]
        public string Postcode {get; set; } = default!;
        [Name("SchoolWebsite")]
        public string SchoolWebsite {get; set; } = default!;
        [Name("TelephoneNum")]
        public string TelephoneNum {get; set; } = default!;
        [Name("HeadTitle (name)")]
        public string HeadTitlename {get; set; } = default!;
        [Name("HeadFirstName")]
        public string HeadFirstName {get; set; } = default!;
        [Name("HeadLastName")]
        public string HeadLastName {get; set; } = default!;
        [Name("HeadPreferredJobTitle")]
        public string HeadPreferredJobTitle {get; set; } = default!;
        [Name("BSOInspectorateName (name)")]
        public string BSOInspectorateNamename {get; set; } = default!;
        [Name("InspectorateReport")]
        public string InspectorateReport {get; set; } = default!;
        [Name("DateOfLastInspectionVisit")]
        public string DateOfLastInspectionVisit {get; set; } = default!;
        [Name("NextInspectionVisit")]
        public string NextInspectionVisit {get; set; } = default!;
        [Name("TeenMoth (name)")]
        public string TeenMothname {get; set; } = default!;
        [Name("TeenMothPlaces")]
        public string TeenMothPlaces {get; set; } = default!;
        [Name("CCF (name)")]
        public string CCFname {get; set; } = default!;
        [Name("SENPRU (name)")]
        public string SENPRUname {get; set; } = default!;
        [Name("EBD (name)")]
        public string EBDname {get; set; } = default!;
        [Name("PlacesPRU")]
        public string PlacesPRU {get; set; } = default!;
        [Name("FTProv (name)")]
        public string FTProvname {get; set; } = default!;
        [Name("EdByOther (name)")]
        public string EdByOthername {get; set; } = default!;
        [Name("Section41Approved (name)")]
        public string Section41Approvedname {get; set; } = default!;
        [Name("SEN1 (name)")]
        public string SEN1name {get; set; } = default!;
        [Name("SEN2 (name)")]
        public string SEN2name {get; set; } = default!;
        [Name("SEN3 (name)")]
        public string SEN3name {get; set; } = default!;
        [Name("SEN4 (name)")]
        public string SEN4name {get; set; } = default!;
        [Name("SEN5 (name)")]
        public string SEN5name {get; set; } = default!;
        [Name("SEN6 (name)")]
        public string SEN6name {get; set; } = default!;
        [Name("SEN7 (name)")]
        public string SEN7name {get; set; } = default!;
        [Name("SEN8 (name)")]
        public string SEN8name {get; set; } = default!;
        [Name("SEN9 (name)")]
        public string SEN9name {get; set; } = default!;
        [Name("SEN10 (name)")]
        public string SEN10name {get; set; } = default!;
        [Name("SEN11 (name)")]
        public string SEN11name {get; set; } = default!;
        [Name("SEN12 (name)")]
        public string SEN12name {get; set; } = default!;
        [Name("SEN13 (name)")]
        public string SEN13name {get; set; } = default!;
        [Name("TypeOfResourcedProvision (name)")]
        public string TypeOfResourcedProvisionname {get; set; } = default!;
        [Name("ResourcedProvisionOnRoll")]
        public string ResourcedProvisionOnRoll {get; set; } = default!;
        [Name("ResourcedProvisionCapacity")]
        public string ResourcedProvisionCapacity {get; set; } = default!;
        [Name("SenUnitOnRoll")]
        public string SenUnitOnRoll {get; set; } = default!;
        [Name("SenUnitCapacity")]
        public string SenUnitCapacity {get; set; } = default!;
        [Name("GOR (code)")]
        public string GORcode {get; set; } = default!;
        [Name("GOR (name)")]
        public string GORname {get; set; } = default!;
        [Name("DistrictAdministrative (code)")]
        public string DistrictAdministrativecode {get; set; } = default!;
        [Name("DistrictAdministrative (name)")]
        public string DistrictAdministrativename {get; set; } = default!;
        [Name("AdministrativeWard (code)")]
        public string AdministrativeWardcode {get; set; } = default!;
        [Name("AdministrativeWard (name)")]
        public string AdministrativeWardname {get; set; } = default!;
        [Name("ParliamentaryConstituency (code)")]
        public string ParliamentaryConstituencycode {get; set; } = default!;
        [Name("ParliamentaryConstituency (name)")]
        public string ParliamentaryConstituencyname {get; set; } = default!;
        [Name("UrbanRural (code)")]
        public string UrbanRuralcode {get; set; } = default!;
        [Name("UrbanRural (name)")]
        public string UrbanRuralname {get; set; } = default!;
        [Name("GSSLACode (name)")]
        public string GSSLACodename {get; set; } = default!;
        [Name("Easting")]
        public string Easting {get; set; } = default!;
        [Name("Northing")]
        public string Northing {get; set; } = default!;
        [Name("MSOA (name)")]
        public string MSOAname {get; set; } = default!;
        [Name("LSOA (name)")]
        public string LSOAname {get; set; } = default!;
        [Name("InspectorateName (name)")]
        public string InspectorateNamename {get; set; } = default!;
        [Name("SENStat")]
        public string SENStat {get; set; } = default!;
        [Name("SENNoStat")]
        public string SENNoStat {get; set; } = default!;
        [Name("BoardingEstablishment (name)")]
        public string BoardingEstablishmentname {get; set; } = default!;
        [Name("PropsName")]
        public string PropsName {get; set; } = default!;
        [Name("PreviousLA (code)")]
        public string PreviousLAcode {get; set; } = default!;
        [Name("PreviousLA (name)")]
        public string PreviousLAname {get; set; } = default!;
        [Name("PreviousEstablishmentNumber")]
        public string PreviousEstablishmentNumber {get; set; } = default!;
        [Name("Country (name)")]
        public string Countryname {get; set; } = default!;
        [Name("UPRN")]
        public string UPRN {get; set; } = default!;
        [Name("SiteName")]
        public string SiteName {get; set; } = default!;
        [Name("QABName (code)")]
        public string QABNamecode {get; set; } = default!;
        [Name("QABName (name)")]
        public string QABNamename {get; set; } = default!;
        [Name("EstablishmentAccredited (code)")]
        public string EstablishmentAccreditedcode {get; set; } = default!;
        [Name("EstablishmentAccredited (name)")]
        public string EstablishmentAccreditedname {get; set; } = default!;
        [Name("QABReport")]
        public string QABReport {get; set; } = default!;
        [Name("CHNumber")]
        public string CHNumber {get; set; } = default!;
        [Name("MSOA (code)")]
        public string MSOAcode {get; set; } = default!;
        [Name("LSOA (code)")]
        public string LSOAcode {get; set; } = default!;
        [Name("FSM")]
        public string FSM {get; set; } = default!;
        [Name("AccreditationExpiryDate")]
        public string AccreditationExpiryDate {get; set; } = default!;

    }
}

