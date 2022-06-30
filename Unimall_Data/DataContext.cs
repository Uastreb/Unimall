using System;
using Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Shared.Entities;

#nullable disable

namespace Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        #region Db sets

        public virtual DbSet<OcAddress> OcAddresses { get; set; }
        public virtual DbSet<OcAddressSimpleField> OcAddressSimpleFields { get; set; }
        public virtual DbSet<OcApi> OcApis { get; set; }
        public virtual DbSet<OcApiIp> OcApiIps { get; set; }
        public virtual DbSet<OcApiSession> OcApiSessions { get; set; }
        public virtual DbSet<OcAttribute> OcAttributes { get; set; }
        public virtual DbSet<OcAttributeDescription> OcAttributeDescriptions { get; set; }
        public virtual DbSet<OcAttributeGroup> OcAttributeGroups { get; set; }
        public virtual DbSet<OcAttributeGroupDescription> OcAttributeGroupDescriptions { get; set; }
        public virtual DbSet<OcBanner> OcBanners { get; set; }
        public virtual DbSet<OcBannerImage> OcBannerImages { get; set; }
        public virtual DbSet<OcCart> OcCarts { get; set; }
        public virtual DbSet<OcCategory> OcCategories { get; set; }
        public virtual DbSet<OcCategoryDescription> OcCategoryDescriptions { get; set; }
        public virtual DbSet<OcCategoryFilter> OcCategoryFilters { get; set; }
        public virtual DbSet<OcCategoryPath> OcCategoryPaths { get; set; }
        public virtual DbSet<OcCategoryToLayout> OcCategoryToLayouts { get; set; }
        public virtual DbSet<OcCategoryToStore> OcCategoryToStores { get; set; }
        public virtual DbSet<OcCountry> OcCountries { get; set; }
        public virtual DbSet<OcCoupon> OcCoupons { get; set; }
        public virtual DbSet<OcCouponCategory> OcCouponCategories { get; set; }
        public virtual DbSet<OcCouponHistory> OcCouponHistories { get; set; }
        public virtual DbSet<OcCouponProduct> OcCouponProducts { get; set; }
        public virtual DbSet<OcCurrency> OcCurrencies { get; set; }
        public virtual DbSet<OcCustomField> OcCustomFields { get; set; }
        public virtual DbSet<OcCustomFieldCustomerGroup> OcCustomFieldCustomerGroups { get; set; }
        public virtual DbSet<OcCustomFieldDescription> OcCustomFieldDescriptions { get; set; }
        public virtual DbSet<OcCustomFieldValue> OcCustomFieldValues { get; set; }
        public virtual DbSet<OcCustomFieldValueDescription> OcCustomFieldValueDescriptions { get; set; }
        public virtual DbSet<OcCustomer> OcCustomers { get; set; }
        public virtual DbSet<OcCustomerActivity> OcCustomerActivities { get; set; }
        public virtual DbSet<OcCustomerAffiliate> OcCustomerAffiliates { get; set; }
        public virtual DbSet<OcCustomerApproval> OcCustomerApprovals { get; set; }
        public virtual DbSet<OcCustomerGroup> OcCustomerGroups { get; set; }
        public virtual DbSet<OcCustomerGroupDescription> OcCustomerGroupDescriptions { get; set; }
        public virtual DbSet<OcCustomerHistory> OcCustomerHistories { get; set; }
        public virtual DbSet<OcCustomerIp> OcCustomerIps { get; set; }
        public virtual DbSet<OcCustomerLogin> OcCustomerLogins { get; set; }
        public virtual DbSet<OcCustomerOnline> OcCustomerOnlines { get; set; }
        public virtual DbSet<OcCustomerReward> OcCustomerRewards { get; set; }
        public virtual DbSet<OcCustomerSearch> OcCustomerSearches { get; set; }
        public virtual DbSet<OcCustomerSimpleField> OcCustomerSimpleFields { get; set; }
        public virtual DbSet<OcCustomerTransaction> OcCustomerTransactions { get; set; }
        public virtual DbSet<OcCustomerWishlist> OcCustomerWishlists { get; set; }
        public virtual DbSet<OcDownload> OcDownloads { get; set; }
        public virtual DbSet<OcDownloadDescription> OcDownloadDescriptions { get; set; }
        public virtual DbSet<OcEvent> OcEvents { get; set; }
        public virtual DbSet<OcExtension> OcExtensions { get; set; }
        public virtual DbSet<OcExtensionInstall> OcExtensionInstalls { get; set; }
        public virtual DbSet<OcExtensionPath> OcExtensionPaths { get; set; }
        public virtual DbSet<OcFilter> OcFilters { get; set; }
        public virtual DbSet<OcFilterDescription> OcFilterDescriptions { get; set; }
        public virtual DbSet<OcFilterGroup> OcFilterGroups { get; set; }
        public virtual DbSet<OcFilterGroupDescription> OcFilterGroupDescriptions { get; set; }
        public virtual DbSet<OcGeoZone> OcGeoZones { get; set; }
        public virtual DbSet<OcGoogleBaseCategory> OcGoogleBaseCategories { get; set; }
        public virtual DbSet<OcGoogleBaseCategoryToCategory> OcGoogleBaseCategoryToCategories { get; set; }
        public virtual DbSet<OcGoogleshoppingCategory> OcGoogleshoppingCategories { get; set; }
        public virtual DbSet<OcGoogleshoppingProduct> OcGoogleshoppingProducts { get; set; }
        public virtual DbSet<OcGoogleshoppingProductStatus> OcGoogleshoppingProductStatuses { get; set; }
        public virtual DbSet<OcGoogleshoppingProductTarget> OcGoogleshoppingProductTargets { get; set; }
        public virtual DbSet<OcGoogleshoppingTarget> OcGoogleshoppingTargets { get; set; }
        public virtual DbSet<OcInformation> OcInformations { get; set; }
        public virtual DbSet<OcInformationDescription> OcInformationDescriptions { get; set; }
        public virtual DbSet<OcInformationToLayout> OcInformationToLayouts { get; set; }
        public virtual DbSet<OcInformationToStore> OcInformationToStores { get; set; }
        public virtual DbSet<OcLanguage> OcLanguages { get; set; }
        public virtual DbSet<OcLayout> OcLayouts { get; set; }
        public virtual DbSet<OcLayoutModule> OcLayoutModules { get; set; }
        public virtual DbSet<OcLayoutRoute> OcLayoutRoutes { get; set; }
        public virtual DbSet<OcLengthClass> OcLengthClasses { get; set; }
        public virtual DbSet<OcLengthClassDescription> OcLengthClassDescriptions { get; set; }
        public virtual DbSet<OcLocation> OcLocations { get; set; }
        public virtual DbSet<OcManufacturer> OcManufacturers { get; set; }
        public virtual DbSet<OcManufacturerToStore> OcManufacturerToStores { get; set; }
        public virtual DbSet<OcMarketing> OcMarketings { get; set; }
        public virtual DbSet<OcModification> OcModifications { get; set; }
        public virtual DbSet<OcModule> OcModules { get; set; }
        public virtual DbSet<OcOctBannerPlu> OcOctBannerPlus { get; set; }
        public virtual DbSet<OcOctBannerPlusImage> OcOctBannerPlusImages { get; set; }
        public virtual DbSet<OcOctBannerPlusImageDescription> OcOctBannerPlusImageDescriptions { get; set; }
        public virtual DbSet<OcOctBlogarticle> OcOctBlogarticles { get; set; }
        public virtual DbSet<OcOctBlogarticleDescription> OcOctBlogarticleDescriptions { get; set; }
        public virtual DbSet<OcOctBlogarticleImage> OcOctBlogarticleImages { get; set; }
        public virtual DbSet<OcOctBlogarticleRelated> OcOctBlogarticleRelateds { get; set; }
        public virtual DbSet<OcOctBlogarticleRelatedProduct> OcOctBlogarticleRelatedProducts { get; set; }
        public virtual DbSet<OcOctBlogarticleToCategory> OcOctBlogarticleToCategories { get; set; }
        public virtual DbSet<OcOctBlogarticleToLayout> OcOctBlogarticleToLayouts { get; set; }
        public virtual DbSet<OcOctBlogarticleToStore> OcOctBlogarticleToStores { get; set; }
        public virtual DbSet<OcOctBlogcategory> OcOctBlogcategories { get; set; }
        public virtual DbSet<OcOctBlogcategoryDescription> OcOctBlogcategoryDescriptions { get; set; }
        public virtual DbSet<OcOctBlogcategoryPath> OcOctBlogcategoryPaths { get; set; }
        public virtual DbSet<OcOctBlogcategoryToLayout> OcOctBlogcategoryToLayouts { get; set; }
        public virtual DbSet<OcOctBlogcategoryToStore> OcOctBlogcategoryToStores { get; set; }
        public virtual DbSet<OcOctBlogcomment> OcOctBlogcomments { get; set; }
        public virtual DbSet<OcOctExtraTab> OcOctExtraTabs { get; set; }
        public virtual DbSet<OcOctExtraTabsDescription> OcOctExtraTabsDescriptions { get; set; }
        public virtual DbSet<OcOctMegamenu> OcOctMegamenus { get; set; }
        public virtual DbSet<OcOctMegamenuBlogcategory> OcOctMegamenuBlogcategories { get; set; }
        public virtual DbSet<OcOctMegamenuCategory> OcOctMegamenuCategories { get; set; }
        public virtual DbSet<OcOctMegamenuDescription> OcOctMegamenuDescriptions { get; set; }
        public virtual DbSet<OcOctMegamenuInformation> OcOctMegamenuInformations { get; set; }
        public virtual DbSet<OcOctMegamenuManufacturer> OcOctMegamenuManufacturers { get; set; }
        public virtual DbSet<OcOctMegamenuProduct> OcOctMegamenuProducts { get; set; }
        public virtual DbSet<OcOctMegamenuToCustomerGroup> OcOctMegamenuToCustomerGroups { get; set; }
        public virtual DbSet<OcOctMegamenuToStore> OcOctMegamenuToStores { get; set; }
        public virtual DbSet<OcOctPopupCallPhone> OcOctPopupCallPhones { get; set; }
        public virtual DbSet<OcOctPopupFoundCheaper> OcOctPopupFoundCheapers { get; set; }
        public virtual DbSet<OcOctProductExtraTab> OcOctProductExtraTabs { get; set; }
        public virtual DbSet<OcOctSlideshowPlu> OcOctSlideshowPlus { get; set; }
        public virtual DbSet<OcOctSlideshowPlusImage> OcOctSlideshowPlusImages { get; set; }
        public virtual DbSet<OcOctSlideshowPlusImageDescription> OcOctSlideshowPlusImageDescriptions { get; set; }
        public virtual DbSet<OcOctSlideshowPlusProduct> OcOctSlideshowPlusProducts { get; set; }
        public virtual DbSet<OcOctSreviewReview> OcOctSreviewReviews { get; set; }
        public virtual DbSet<OcOctSreviewReviewsVote> OcOctSreviewReviewsVotes { get; set; }
        public virtual DbSet<OcOctSreviewSubject> OcOctSreviewSubjects { get; set; }
        public virtual DbSet<OcOctSreviewSubjectDescription> OcOctSreviewSubjectDescriptions { get; set; }
        public virtual DbSet<OcOctSreviewSubjectToStore> OcOctSreviewSubjectToStores { get; set; }
        public virtual DbSet<OcOctSubscribe> OcOctSubscribes { get; set; }
        public virtual DbSet<OcOption> OcOptions { get; set; }
        public virtual DbSet<OcOptionDescription> OcOptionDescriptions { get; set; }
        public virtual DbSet<OcOptionValue> OcOptionValues { get; set; }
        public virtual DbSet<OcOptionValueDescription> OcOptionValueDescriptions { get; set; }
        public virtual DbSet<OcOrder> OcOrders { get; set; }
        public virtual DbSet<OcOrderHistory> OcOrderHistories { get; set; }
        public virtual DbSet<OcOrderOption> OcOrderOptions { get; set; }
        public virtual DbSet<OcOrderProduct> OcOrderProducts { get; set; }
        public virtual DbSet<OcOrderRecurring> OcOrderRecurrings { get; set; }
        public virtual DbSet<OcOrderRecurringTransaction> OcOrderRecurringTransactions { get; set; }
        public virtual DbSet<OcOrderShipment> OcOrderShipments { get; set; }
        public virtual DbSet<OcOrderSimpleField> OcOrderSimpleFields { get; set; }
        public virtual DbSet<OcOrderStatus> OcOrderStatuses { get; set; }
        public virtual DbSet<OcOrderTotal> OcOrderTotals { get; set; }
        public virtual DbSet<OcOrderVoucher> OcOrderVouchers { get; set; }
        public virtual DbSet<OcProduct> OcProducts { get; set; }
        public virtual DbSet<OcProductAttribute> OcProductAttributes { get; set; }
        public virtual DbSet<OcProductDescription> OcProductDescriptions { get; set; }
        public virtual DbSet<OcProductDiscount> OcProductDiscounts { get; set; }
        public virtual DbSet<OcProductFilter> OcProductFilters { get; set; }
        public virtual DbSet<OcProductImage> OcProductImages { get; set; }
        public virtual DbSet<OcProductOption> OcProductOptions { get; set; }
        public virtual DbSet<OcProductOptionValue> OcProductOptionValues { get; set; }
        public virtual DbSet<OcProductRecurring> OcProductRecurrings { get; set; }
        public virtual DbSet<OcProductRelated> OcProductRelateds { get; set; }
        public virtual DbSet<OcProductReward> OcProductRewards { get; set; }
        public virtual DbSet<OcProductSpecial> OcProductSpecials { get; set; }
        public virtual DbSet<OcProductToCategory> OcProductToCategories { get; set; }
        public virtual DbSet<OcProductToDownload> OcProductToDownloads { get; set; }
        public virtual DbSet<OcProductToLayout> OcProductToLayouts { get; set; }
        public virtual DbSet<OcProductToStore> OcProductToStores { get; set; }
        public virtual DbSet<OcRecurring> OcRecurrings { get; set; }
        public virtual DbSet<OcRecurringDescription> OcRecurringDescriptions { get; set; }
        public virtual DbSet<OcReturn> OcReturns { get; set; }
        public virtual DbSet<OcReturnAction> OcReturnActions { get; set; }
        public virtual DbSet<OcReturnHistory> OcReturnHistories { get; set; }
        public virtual DbSet<OcReturnReason> OcReturnReasons { get; set; }
        public virtual DbSet<OcReturnStatus> OcReturnStatuses { get; set; }
        public virtual DbSet<OcReview> OcReviews { get; set; }
        public virtual DbSet<OcSeoUrl> OcSeoUrls { get; set; }
        public virtual DbSet<OcSession> OcSessions { get; set; }
        public virtual DbSet<OcSetting> OcSettings { get; set; }
        public virtual DbSet<OcShippingCourier> OcShippingCouriers { get; set; }
        public virtual DbSet<OcSimpleCart> OcSimpleCarts { get; set; }
        public virtual DbSet<OcStatistic> OcStatistics { get; set; }
        public virtual DbSet<OcStockStatus> OcStockStatuses { get; set; }
        public virtual DbSet<OcStore> OcStores { get; set; }
        public virtual DbSet<OcTaxClass> OcTaxClasses { get; set; }
        public virtual DbSet<OcTaxRate> OcTaxRates { get; set; }
        public virtual DbSet<OcTaxRateToCustomerGroup> OcTaxRateToCustomerGroups { get; set; }
        public virtual DbSet<OcTaxRule> OcTaxRules { get; set; }
        public virtual DbSet<OcTheme> OcThemes { get; set; }
        public virtual DbSet<OcTranslation> OcTranslations { get; set; }
        public virtual DbSet<OcUpload> OcUploads { get; set; }
        public virtual DbSet<OcUser> OcUsers { get; set; }
        public virtual DbSet<OcUserGroup> OcUserGroups { get; set; }
        public virtual DbSet<OcVoucher> OcVouchers { get; set; }
        public virtual DbSet<OcVoucherHistory> OcVoucherHistories { get; set; }
        public virtual DbSet<OcVoucherTheme> OcVoucherThemes { get; set; }
        public virtual DbSet<OcVoucherThemeDescription> OcVoucherThemeDescriptions { get; set; }
        public virtual DbSet<OcWeightClass> OcWeightClasses { get; set; }
        public virtual DbSet<OcWeightClassDescription> OcWeightClassDescriptions { get; set; }
        public virtual DbSet<OcZone> OcZones { get; set; }
        public virtual DbSet<OcZoneToGeoZone> OcZoneToGeoZones { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterDbModels();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
