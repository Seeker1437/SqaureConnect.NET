using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates a merchant's type of business.
    /// </summary>
    /// <remarks>
    /// Business type values are applicable to all countries supported by Square unless otherwise indicated.
    /// </remarks>
    public enum MerchatBusinessType
    {
        [Display(Description = "ACCOUNTING")]
        Accounting,

        [Display(Description = "APPAREL_AND_ACCESSORY_SHOPS")]
        ApparelAndAccessoryShops,

        [Display(Description = "ART_DEALERS_GALLERIES")]
        ArtDealersGalleries,

        [Display(Description = "ART_DESIGN_AND_PHOTOGRAPHY")]
        ArtDesignAndPhotography,

        [Display(Description = "BAR_CLUB_LOUNGE")]
        BarClubLounge,

        [Display(Description = "BEAUTY_AND_BARBER_SHOPS")]
        BeautyAndBarberShops,

        [Display(Description = "BOOK_STORES")]
        BookStores,

        [Display(Description = "BUSINESS_SERVICES")]
        BusinessServices,

        [Display(Description = "CATERING")]
        Catering,

        [Display(Description = "CHARITABLE_SOCIAL_SERVICE_ORGANIZATIONS")]
        CharitableSocialServiceOrganizations,

        [Display(Description = "CHARITIBLE_ORGS")]
        CharitibleOrgs,

        [Display(Description = "CLEANING_SERVICES")]
        CleaningServices,

        [Display(Description = "COMPUTER_EQUIPMENT_SOFTWARE_MAINTENANCE_REPAIR_SERVICES")]
        ComputerEquipmentSoftwareMaintenanceRepairServices,

        [Display(Description = "CONSULTANT")]
        Consultant,

        [Display(Description = "CONTRACTORS")]
        Contractors,

        [Display(Description = "DELIVERY_SERVICES")]
        DeliveryServices,

        [Display(Description = "DENTISTRY")]
        Dentistry,

        [Display(Description = "EDUCATION")]
        Education,

        [Display(Description = "FOOD_STORES_CONVENIENCE_STORES_AND_SPECIALTY_MARKETS")]
        FoodStoresConvenienceStoresAndSpecialtyMarkets,

        [Display(Description = "FOOD_TRUCK_CART")]
        FoodTruckCart,

        [Display(Description = "FURNITURE_HOME_AND_OFFICE_EQUIPMENT")]
        FurnitureHomeAndOfficeEquipment,

        [Display(Description = "FURNITURE_HOME_GOODS")]
        FurnitureHomeGoods,

        [Display(Description = "HOTELS_AND_LODGING")]
        HotelsAndLodging,

        [Display(Description = "INDIVIDUAL_USE")]
        IndividualUse,

        [Display(Description = "JEWELRY_AND_WATCHES")]
        JewelryAndWatches,

        [Display(Description = "LANDSCAPING_AND_HORTICULTURAL_SERVICES")]
        LandscapingAndHorticulturalServices,

        [Display(Description = "LANGUAGE_SCHOOLS")]
        LanguageSchools,

        [Display(Description = "LEGAL_SERVICES")]
        LegalServices,

        [Display(Description = "MEDICAL_PRACTITIONERS")]
        MedicalPractitioners,

        [Display(Description = "MEDICAL_SERVICES_AND_HEALTH_PRACTITIONERS")]
        MedicalServicesAndHealthPractitioners,

        [Display(Description = "MEMBERSHIP_ORGANIZATIONS")]
        MembershipOrganizations,

        [Display(Description = "MUSIC_AND_ENTERTAINMENT")]
        MusicAndEntertainment,

        [Display(Description = "OTHER")]
        Other,

        [Display(Description = "OUTDOOR_MARKETS")]
        OutdoorMarkets,

        [Display(Description = "PERSONAL_SERVICES")]
        PersonalServices,

        [Display(Description = "POLITICAL_ORGANIZATIONS")]
        PoliticalOrganization,

        [Display(Description = "PROFESSIONAL_SERVICES")]
        ProfessionalServices,

        [Display(Description = "REAL_ESTATE")]
        RealEstate,

        [Display(Description = "RECREATION_SERVICES")]
        RecreationServices,

        [Display(Description = "REPAIR_SHOPS_AND_RELATED_SERVICES")]
        RepairShopsAndRelatedServices,

        [Display(Description = "RESTAURANTS")]
        Restaurants,

        [Display(Description = "RETAIL_SHOPS")]
        RetailShops,

        [Display(Description = "SCHOOLS_AND_EDUCATIONAL_SERVICES")]
        SchoolAndEducationServices,

        [Display(Description = "SPORTING_GOODS")]
        SportingGoods,

        [Display(Description = "TAXICABS_AND_LIMOUSINES")]
        TaxicabsAndLimousines,

        [Display(Description = "TICKET_SALES")]
        TicketSales,

        [Display(Description = "TOURISM")]
        Tourism,

        [Display(Description = "TRAVEL_TOURISM")]
        TravelTourisum,

        [Display(Description = "VETERINARY_SERVICES")]
        VeterinaryServices,

        [Display(Description = "WEB_DEV_DESIGN")]
        WebDevDesign,

    }
}
