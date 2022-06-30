using Microsoft.EntityFrameworkCore;
using Shared.Entities;

namespace Data.Extensions
{
    internal static class DbModelSettings
    {
        internal static ModelBuilder RegisterDbModels(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OcAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_address");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_1");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_2");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("postcode");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            modelBuilder.Entity<OcAddressSimpleField>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_address_simple_fields");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Field20).HasColumnName("field20");

                entity.Property(e => e.Field21).HasColumnName("field21");

                entity.Property(e => e.Field22).HasColumnName("field22");

                entity.Property(e => e.Metadata).HasColumnName("metadata");
            });

            modelBuilder.Entity<OcApi>(entity =>
            {
                entity.HasKey(e => e.ApiId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_api");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OcApiIp>(entity =>
            {
                entity.HasKey(e => e.ApiIpId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_api_ip");

                entity.Property(e => e.ApiIpId).HasColumnName("api_ip_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OcApiSession>(entity =>
            {
                entity.HasKey(e => e.ApiSessionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_api_session");

                entity.Property(e => e.ApiSessionId).HasColumnName("api_session_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OcAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_attribute");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcAttributeDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_attribute_description");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.AttributeGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_attribute_group");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcAttributeGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_attribute_group_description");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_banner");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcBannerImage>(entity =>
            {
                entity.HasKey(e => e.BannerImageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_banner_image");

                entity.Property(e => e.BannerImageId).HasColumnName("banner_image_id");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_cart");

                entity.HasIndex(e => new { e.ApiId, e.CustomerId, e.SessionId, e.ProductId, e.RecurringId }, "cart_id");

                entity.Property(e => e.CartId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("cart_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Option)
                    .IsRequired()
                    .HasColumnName("option");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OcCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_category");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Column).HasColumnName("column");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.OctImage)
                    .HasMaxLength(255)
                    .HasColumnName("oct_image");

                entity.Property(e => e.PageGroupLinks)
                    .IsRequired()
                    .HasColumnName("page_group_links");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Top).HasColumnName("top");
            });

            modelBuilder.Entity<OcCategoryDescription>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_category_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCategoryFilter>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.FilterId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_category_filter");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OcCategoryPath>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PathId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_category_path");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PathId).HasColumnName("path_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<OcCategoryToLayout>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_category_to_layout");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcCategoryToStore>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_category_to_store");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.AddressFormat)
                    .IsRequired()
                    .HasColumnName("address_format");

                entity.Property(e => e.IsoCode2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("iso_code_2");

                entity.Property(e => e.IsoCode3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("iso_code_3");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PostcodeRequired).HasColumnName("postcode_required");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OcCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_coupon");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("discount");

                entity.Property(e => e.Logged).HasColumnName("logged");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Shipping).HasColumnName("shipping");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);

                entity.Property(e => e.UsesCustomer)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("uses_customer");

                entity.Property(e => e.UsesTotal).HasColumnName("uses_total");
            });

            modelBuilder.Entity<OcCouponCategory>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_coupon_category");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcCouponHistory>(entity =>
            {
                entity.HasKey(e => e.CouponHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_coupon_history");

                entity.Property(e => e.CouponHistoryId).HasColumnName("coupon_history_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OcCouponProduct>(entity =>
            {
                entity.HasKey(e => e.CouponProductId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_coupon_product");

                entity.Property(e => e.CouponProductId).HasColumnName("coupon_product_id");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_currency");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("code");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.DecimalPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("decimal_place")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SymbolLeft)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_left");

                entity.Property(e => e.SymbolRight)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_right");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("double(15,8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcCustomField>(entity =>
            {
                entity.HasKey(e => e.CustomFieldId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_custom_field");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("location");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Validation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("validation");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcCustomFieldCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_custom_field_customer_group");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Required).HasColumnName("required");
            });

            modelBuilder.Entity<OcCustomFieldDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_custom_field_description");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomFieldValue>(entity =>
            {
                entity.HasKey(e => e.CustomFieldValueId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_custom_field_value");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcCustomFieldValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldValueId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_custom_field_value_description");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Cart).HasColumnName("cart");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Newsletter).HasColumnName("newsletter");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.Safe).HasColumnName("safe");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token");

                entity.Property(e => e.Wishlist).HasColumnName("wishlist");
            });

            modelBuilder.Entity<OcCustomerActivity>(entity =>
            {
                entity.HasKey(e => e.CustomerActivityId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_activity");

                entity.Property(e => e.CustomerActivityId).HasColumnName("customer_activity_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("key");
            });

            modelBuilder.Entity<OcCustomerAffiliate>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_affiliate");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.BankAccountName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_name");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_number");

                entity.Property(e => e.BankBranchNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_branch_number");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankSwiftCode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_swift_code");

                entity.Property(e => e.Cheque)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cheque");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(4,2)")
                    .HasColumnName("commission");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("payment");

                entity.Property(e => e.Paypal)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("paypal");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tax");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<OcCustomerApproval>(entity =>
            {
                entity.HasKey(e => e.CustomerApprovalId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_approval");

                entity.Property(e => e.CustomerApprovalId).HasColumnName("customer_approval_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcCustomerGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_group");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Approval).HasColumnName("approval");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcCustomerGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_group_description");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcCustomerHistory>(entity =>
            {
                entity.HasKey(e => e.CustomerHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_history");

                entity.Property(e => e.CustomerHistoryId).HasColumnName("customer_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");
            });

            modelBuilder.Entity<OcCustomerIp>(entity =>
            {
                entity.HasKey(e => e.CustomerIpId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_ip");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerIpId).HasColumnName("customer_ip_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OcCustomerLogin>(entity =>
            {
                entity.HasKey(e => e.CustomerLoginId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_login");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerLoginId).HasColumnName("customer_login_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<OcCustomerOnline>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_online");

                entity.Property(e => e.Ip)
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<OcCustomerReward>(entity =>
            {
                entity.HasKey(e => e.CustomerRewardId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_reward");

                entity.Property(e => e.CustomerRewardId).HasColumnName("customer_reward_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Points).HasColumnName("points");
            });

            modelBuilder.Entity<OcCustomerSearch>(entity =>
            {
                entity.HasKey(e => e.CustomerSearchId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_search");

                entity.Property(e => e.CustomerSearchId).HasColumnName("customer_search_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Products).HasColumnName("products");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            });

            modelBuilder.Entity<OcCustomerSimpleField>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_simple_fields");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Metadata).HasColumnName("metadata");
            });

            modelBuilder.Entity<OcCustomerTransaction>(entity =>
            {
                entity.HasKey(e => e.CustomerTransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_transaction");

                entity.Property(e => e.CustomerTransactionId).HasColumnName("customer_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OcCustomerWishlist>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_customer_wishlist");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");
            });

            modelBuilder.Entity<OcDownload>(entity =>
            {
                entity.HasKey(e => e.DownloadId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_download");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(160)
                    .HasColumnName("filename");

                entity.Property(e => e.Mask)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("mask");
            });

            modelBuilder.Entity<OcDownloadDescription>(entity =>
            {
                entity.HasKey(e => new { e.DownloadId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_download_description");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_event");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Trigger)
                    .IsRequired()
                    .HasColumnName("trigger");
            });

            modelBuilder.Entity<OcExtension>(entity =>
            {
                entity.HasKey(e => e.ExtensionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_extension");

                entity.Property(e => e.ExtensionId).HasColumnName("extension_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcExtensionInstall>(entity =>
            {
                entity.HasKey(e => e.ExtensionInstallId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_extension_install");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.ExtensionDownloadId).HasColumnName("extension_download_id");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("filename");
            });

            modelBuilder.Entity<OcExtensionPath>(entity =>
            {
                entity.HasKey(e => e.ExtensionPathId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_extension_path");

                entity.Property(e => e.ExtensionPathId).HasColumnName("extension_path_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<OcFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_filter");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcFilterDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_filter_description");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcFilterGroup>(entity =>
            {
                entity.HasKey(e => e.FilterGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_filter_group");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcFilterGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_filter_group_description");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcGeoZone>(entity =>
            {
                entity.HasKey(e => e.GeoZoneId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_geo_zone");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcGoogleBaseCategory>(entity =>
            {
                entity.HasKey(e => e.GoogleBaseCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_google_base_category");

                entity.Property(e => e.GoogleBaseCategoryId).HasColumnName("google_base_category_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcGoogleBaseCategoryToCategory>(entity =>
            {
                entity.HasKey(e => new { e.GoogleBaseCategoryId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_google_base_category_to_category");

                entity.Property(e => e.GoogleBaseCategoryId).HasColumnName("google_base_category_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcGoogleshoppingCategory>(entity =>
            {
                entity.HasKey(e => new { e.GoogleProductCategory, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_googleshopping_category");

                entity.HasIndex(e => new { e.CategoryId, e.StoreId }, "category_id_store_id");

                entity.Property(e => e.GoogleProductCategory)
                    .HasMaxLength(10)
                    .HasColumnName("google_product_category");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcGoogleshoppingProduct>(entity =>
            {
                entity.HasKey(e => e.ProductAdvertiseGoogleId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_googleshopping_product");

                entity.HasIndex(e => new { e.ProductId, e.StoreId }, "product_id_store_id")
                    .IsUnique();

                entity.Property(e => e.ProductAdvertiseGoogleId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("product_advertise_google_id");

                entity.Property(e => e.Adult).HasColumnName("adult");

                entity.Property(e => e.AgeGroup)
                    .HasColumnType("enum('newborn','infant','toddler','kids','adult')")
                    .HasColumnName("age_group");

                entity.Property(e => e.Clicks).HasColumnName("clicks");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.Condition)
                    .HasColumnType("enum('new','refurbished','used')")
                    .HasColumnName("condition");

                entity.Property(e => e.ConversionValue)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("conversion_value");

                entity.Property(e => e.Conversions).HasColumnName("conversions");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("cost");

                entity.Property(e => e.DestinationStatus)
                    .IsRequired()
                    .HasColumnType("enum('pending','approved','disapproved')")
                    .HasColumnName("destination_status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('male','female','unisex')")
                    .HasColumnName("gender");

                entity.Property(e => e.GoogleProductCategory)
                    .HasMaxLength(10)
                    .HasColumnName("google_product_category");

                entity.Property(e => e.HasIssues).HasColumnName("has_issues");

                entity.Property(e => e.Impressions).HasColumnName("impressions");

                entity.Property(e => e.IsBundle).HasColumnName("is_bundle");

                entity.Property(e => e.IsModified).HasColumnName("is_modified");

                entity.Property(e => e.Multipack).HasColumnName("multipack");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SizeSystem)
                    .HasColumnType("enum('AU','BR','CN','DE','EU','FR','IT','JP','MEX','UK','US')")
                    .HasColumnName("size_system");

                entity.Property(e => e.SizeType)
                    .HasColumnType("enum('regular','petite','plus','big and tall','maternity')")
                    .HasColumnName("size_type");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcGoogleshoppingProductStatus>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId, e.ProductVariationId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_googleshopping_product_status");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.ProductVariationId)
                    .HasMaxLength(64)
                    .HasColumnName("product_variation_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DataQualityIssues)
                    .IsRequired()
                    .HasColumnName("data_quality_issues");

                entity.Property(e => e.DestinationStatuses)
                    .IsRequired()
                    .HasColumnName("destination_statuses");

                entity.Property(e => e.GoogleExpirationDate).HasColumnName("google_expiration_date");

                entity.Property(e => e.ItemLevelIssues)
                    .IsRequired()
                    .HasColumnName("item_level_issues");
            });

            modelBuilder.Entity<OcGoogleshoppingProductTarget>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.AdvertiseGoogleTargetId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_googleshopping_product_target");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AdvertiseGoogleTargetId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("advertise_google_target_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcGoogleshoppingTarget>(entity =>
            {
                entity.HasKey(e => e.AdvertiseGoogleTargetId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_googleshopping_target");

                entity.HasIndex(e => e.StoreId, "store_id");

                entity.Property(e => e.AdvertiseGoogleTargetId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("advertise_google_target_id");

                entity.Property(e => e.Budget)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("budget");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("campaign_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("country")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added");

                entity.Property(e => e.Feeds)
                    .IsRequired()
                    .HasColumnName("feeds");

                entity.Property(e => e.Roas).HasColumnName("roas");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('paused','active')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'paused'");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcInformation>(entity =>
            {
                entity.HasKey(e => e.InformationId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_information");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.Bottom).HasColumnName("bottom");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OcInformationDescription>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_information_description");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcInformationToLayout>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_information_to_layout");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcInformationToStore>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_information_to_store");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_language");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("code");

                entity.Property(e => e.Directory)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("directory");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("image");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("locale");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcLayout>(entity =>
            {
                entity.HasKey(e => e.LayoutId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_layout");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcLayoutModule>(entity =>
            {
                entity.HasKey(e => e.LayoutModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_layout_module");

                entity.Property(e => e.LayoutModuleId).HasColumnName("layout_module_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("position");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcLayoutRoute>(entity =>
            {
                entity.HasKey(e => e.LayoutRouteId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_layout_route");

                entity.Property(e => e.LayoutRouteId).HasColumnName("layout_route_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcLengthClass>(entity =>
            {
                entity.HasKey(e => e.LengthClassId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_length_class");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcLengthClassDescription>(entity =>
            {
                entity.HasKey(e => new { e.LengthClassId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_length_class_description");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<OcLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_location");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Geocode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("geocode");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Open)
                    .IsRequired()
                    .HasColumnName("open");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OcManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_manufacturer");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcManufacturerToStore>(entity =>
            {
                entity.HasKey(e => new { e.ManufacturerId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_manufacturer_to_store");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcMarketing>(entity =>
            {
                entity.HasKey(e => e.MarketingId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_marketing");

                entity.Property(e => e.MarketingId).HasColumnName("marketing_id");

                entity.Property(e => e.Clicks).HasColumnName("clicks");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcModification>(entity =>
            {
                entity.HasKey(e => e.ModificationId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_modification");

                entity.Property(e => e.ModificationId).HasColumnName("modification_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.ExtensionInstallId).HasColumnName("extension_install_id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("version");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("xml");
            });

            modelBuilder.Entity<OcModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_module");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");
            });

            modelBuilder.Entity<OcOctBannerPlu>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_banner_plus");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcOctBannerPlusImage>(entity =>
            {
                entity.HasKey(e => e.BannerImageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_banner_plus_image");

                entity.Property(e => e.BannerImageId).HasColumnName("banner_image_id");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("background_color");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.ButtonBackground)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_background");

                entity.Property(e => e.ButtonBackgroundHover)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_background_hover");

                entity.Property(e => e.ButtonColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_color");

                entity.Property(e => e.ButtonTextHover)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_text_hover");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.TextColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("text_color");

                entity.Property(e => e.TitleColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title_color");
            });

            modelBuilder.Entity<OcOctBannerPlusImageDescription>(entity =>
            {
                entity.HasKey(e => new { e.BannerImageId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_banner_plus_image_description");

                entity.Property(e => e.BannerImageId).HasColumnName("banner_image_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Button)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("button");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcOctBlogarticle>(entity =>
            {
                entity.HasKey(e => e.BlogarticleId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateAvailable).HasColumnName("date_available");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Viewed).HasColumnName("viewed");
            });

            modelBuilder.Entity<OcOctBlogarticleDescription>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ShotDescription)
                    .IsRequired()
                    .HasColumnName("shot_description");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<OcOctBlogarticleImage>(entity =>
            {
                entity.HasKey(e => e.ArticleImageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_image");

                entity.HasIndex(e => e.BlogarticleId, "blogarticle_id");

                entity.Property(e => e.ArticleImageId).HasColumnName("article_image_id");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcOctBlogarticleRelated>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.RelatedId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_related");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.RelatedId).HasColumnName("related_id");
            });

            modelBuilder.Entity<OcOctBlogarticleRelatedProduct>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_related_product");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcOctBlogarticleToCategory>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.BlogcategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_to_category");

                entity.HasIndex(e => e.BlogcategoryId, "blogcategory_id");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");
            });

            modelBuilder.Entity<OcOctBlogarticleToLayout>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_to_layout");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcOctBlogarticleToStore>(entity =>
            {
                entity.HasKey(e => new { e.BlogarticleId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogarticle_to_store");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcOctBlogcategory>(entity =>
            {
                entity.HasKey(e => e.BlogcategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcategory");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OcOctBlogcategoryDescription>(entity =>
            {
                entity.HasKey(e => new { e.BlogcategoryId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcategory_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaH1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_h1");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOctBlogcategoryPath>(entity =>
            {
                entity.HasKey(e => new { e.BlogcategoryId, e.BlogPathId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcategory_path");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");

                entity.Property(e => e.BlogPathId).HasColumnName("blog_path_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<OcOctBlogcategoryToLayout>(entity =>
            {
                entity.HasKey(e => new { e.BlogcategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcategory_to_layout");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcOctBlogcategoryToStore>(entity =>
            {
                entity.HasKey(e => new { e.BlogcategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcategory_to_store");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcOctBlogcomment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_blogcomments");

                entity.HasIndex(e => e.BlogarticleId, "blogarticle_id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.AdminText)
                    .IsRequired()
                    .HasColumnName("admin_text");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.BlogarticleId).HasColumnName("blogarticle_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcOctExtraTab>(entity =>
            {
                entity.HasKey(e => e.ExtraTabId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_extra_tabs");

                entity.Property(e => e.ExtraTabId).HasColumnName("extra_tab_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OcOctExtraTabsDescription>(entity =>
            {
                entity.HasKey(e => new { e.ExtraTabId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_extra_tabs_description");

                entity.Property(e => e.ExtraTabId).HasColumnName("extra_tab_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcOctMegamenu>(entity =>
            {
                entity.HasKey(e => e.MegamenuId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DisplayType)
                    .HasColumnName("display_type")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ImgHeight)
                    .HasColumnName("img_height")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.ImgWidth)
                    .HasColumnName("img_width")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LimitItem)
                    .HasColumnName("limit_item")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.OpenLinkType).HasColumnName("open_link_type");

                entity.Property(e => e.ShowImg)
                    .IsRequired()
                    .HasColumnName("show_img")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SubCategories).HasColumnName("sub_categories");
            });

            modelBuilder.Entity<OcOctMegamenuBlogcategory>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.BlogcategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_blogcategory");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.BlogcategoryId).HasColumnName("blogcategory_id");
            });

            modelBuilder.Entity<OcOctMegamenuCategory>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_category");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OcOctMegamenuDescription>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_description");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.CustomHtml)
                    .IsRequired()
                    .HasColumnName("custom_html");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcOctMegamenuInformation>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.InformationId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_information");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.InformationId).HasColumnName("information_id");
            });

            modelBuilder.Entity<OcOctMegamenuManufacturer>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.ManufacturerId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_manufacturer");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");
            });

            modelBuilder.Entity<OcOctMegamenuProduct>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_product");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcOctMegamenuToCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_to_customer_group");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OcOctMegamenuToStore>(entity =>
            {
                entity.HasKey(e => new { e.MegamenuId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_megamenu_to_store");

                entity.Property(e => e.MegamenuId).HasColumnName("megamenu_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcOctPopupCallPhone>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_popup_call_phone");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info");

                entity.Property(e => e.Processed).HasColumnName("processed");
            });

            modelBuilder.Entity<OcOctPopupFoundCheaper>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_popup_found_cheaper");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasColumnName("info");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note");

                entity.Property(e => e.Processed).HasColumnName("processed");
            });

            modelBuilder.Entity<OcOctProductExtraTab>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ExtraTabId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_product_extra_tabs");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ExtraTabId).HasColumnName("extra_tab_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcOctSlideshowPlu>(entity =>
            {
                entity.HasKey(e => e.SlideshowId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_slideshow_plus");

                entity.Property(e => e.SlideshowId).HasColumnName("slideshow_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.PositionBanners)
                    .IsRequired()
                    .HasColumnName("position_banners")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusAdditionalBanners)
                    .IsRequired()
                    .HasColumnName("status_additional_banners")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OcOctSlideshowPlusImage>(entity =>
            {
                entity.HasKey(e => e.SlideshowImageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_slideshow_plus_image");

                entity.Property(e => e.SlideshowImageId).HasColumnName("slideshow_image_id");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("background_color");

                entity.Property(e => e.ButtonBackground)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_background");

                entity.Property(e => e.ButtonBackgroundHover)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_background_hover");

                entity.Property(e => e.ButtonColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_color");

                entity.Property(e => e.ButtonColorHover)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("button_color_hover");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.SlideshowId).HasColumnName("slideshow_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.TextColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("text_color");

                entity.Property(e => e.TitleColor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title_color");
            });

            modelBuilder.Entity<OcOctSlideshowPlusImageDescription>(entity =>
            {
                entity.HasKey(e => new { e.SlideshowImageId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_slideshow_plus_image_description");

                entity.Property(e => e.SlideshowImageId).HasColumnName("slideshow_image_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Button)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("button");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.SlideshowId).HasColumnName("slideshow_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcOctSlideshowPlusProduct>(entity =>
            {
                entity.HasKey(e => new { e.SlideshowId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_slideshow_plus_product");

                entity.Property(e => e.SlideshowId).HasColumnName("slideshow_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcOctSreviewReview>(entity =>
            {
                entity.HasKey(e => e.OctSreviewReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_sreview_reviews");

                entity.Property(e => e.OctSreviewReviewId).HasColumnName("oct_sreview_review_id");

                entity.Property(e => e.AdminText)
                    .IsRequired()
                    .HasColumnName("admin_text");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.AvgRating).HasColumnName("avg_rating");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcOctSreviewReviewsVote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oc_oct_sreview_reviews_vote");

                entity.Property(e => e.OctSreviewReviewId).HasColumnName("oct_sreview_review_id");

                entity.Property(e => e.OctSreviewSubjectId).HasColumnName("oct_sreview_subject_id");

                entity.Property(e => e.Rating).HasColumnName("rating");
            });

            modelBuilder.Entity<OcOctSreviewSubject>(entity =>
            {
                entity.HasKey(e => e.OctSreviewSubjectId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_sreview_subject");

                entity.Property(e => e.OctSreviewSubjectId).HasColumnName("oct_sreview_subject_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubjectRatingCount1).HasColumnName("subject_rating_count1");

                entity.Property(e => e.SubjectRatingCount2).HasColumnName("subject_rating_count2");

                entity.Property(e => e.SubjectRatingCount3).HasColumnName("subject_rating_count3");

                entity.Property(e => e.SubjectRatingCount4).HasColumnName("subject_rating_count4");

                entity.Property(e => e.SubjectRatingCount5).HasColumnName("subject_rating_count5");
            });

            modelBuilder.Entity<OcOctSreviewSubjectDescription>(entity =>
            {
                entity.HasKey(e => new { e.OctSreviewSubjectId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_sreview_subject_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.OctSreviewSubjectId).HasColumnName("oct_sreview_subject_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOctSreviewSubjectToStore>(entity =>
            {
                entity.HasKey(e => new { e.OctSreviewSubjectId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_sreview_subject_to_store");

                entity.Property(e => e.OctSreviewSubjectId).HasColumnName("oct_sreview_subject_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcOctSubscribe>(entity =>
            {
                entity.HasKey(e => e.SubscribeId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_oct_subscribe");

                entity.Property(e => e.SubscribeId).HasColumnName("subscribe_id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("hash");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OcOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_option");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcOptionDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_option_description");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOptionValue>(entity =>
            {
                entity.HasKey(e => e.OptionValueId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_option_value");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcOptionValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionValueId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_option_value_description");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.OptionId).HasColumnName("option_id");
            });

            modelBuilder.Entity<OcOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AcceptLanguage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("accept_language");

                entity.Property(e => e.AffiliateId).HasColumnName("affiliate_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("commission");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CurrencyValue)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("currency_value")
                    .HasDefaultValueSql("'1.00000000'");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.ForwardedIp)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("forwarded_ip");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoice_no");

                entity.Property(e => e.InvoicePrefix)
                    .IsRequired()
                    .HasMaxLength(26)
                    .HasColumnName("invoice_prefix");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.MarketingId).HasColumnName("marketing_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");

                entity.Property(e => e.PaymentAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_1");

                entity.Property(e => e.PaymentAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_2");

                entity.Property(e => e.PaymentAddressFormat)
                    .IsRequired()
                    .HasColumnName("payment_address_format");

                entity.Property(e => e.PaymentCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_city");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_code");

                entity.Property(e => e.PaymentCompany)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("payment_company");

                entity.Property(e => e.PaymentCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_country");

                entity.Property(e => e.PaymentCountryId).HasColumnName("payment_country_id");

                entity.Property(e => e.PaymentCustomField)
                    .IsRequired()
                    .HasColumnName("payment_custom_field");

                entity.Property(e => e.PaymentFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_firstname");

                entity.Property(e => e.PaymentLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_lastname");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_method");

                entity.Property(e => e.PaymentPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("payment_postcode");

                entity.Property(e => e.PaymentZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_zone");

                entity.Property(e => e.PaymentZoneId).HasColumnName("payment_zone_id");

                entity.Property(e => e.ShippingAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_1");

                entity.Property(e => e.ShippingAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_2");

                entity.Property(e => e.ShippingAddressFormat)
                    .IsRequired()
                    .HasColumnName("shipping_address_format");

                entity.Property(e => e.ShippingCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_city");

                entity.Property(e => e.ShippingCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_code");

                entity.Property(e => e.ShippingCompany)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("shipping_company");

                entity.Property(e => e.ShippingCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_country");

                entity.Property(e => e.ShippingCountryId).HasColumnName("shipping_country_id");

                entity.Property(e => e.ShippingCustomField)
                    .IsRequired()
                    .HasColumnName("shipping_custom_field");

                entity.Property(e => e.ShippingFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_firstname");

                entity.Property(e => e.ShippingLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_lastname");

                entity.Property(e => e.ShippingMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_method");

                entity.Property(e => e.ShippingPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("shipping_postcode");

                entity.Property(e => e.ShippingZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_zone");

                entity.Property(e => e.ShippingZoneId).HasColumnName("shipping_zone_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("store_url");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");
            });

            modelBuilder.Entity<OcOrderHistory>(entity =>
            {
                entity.HasKey(e => e.OrderHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_history");

                entity.Property(e => e.OrderHistoryId).HasColumnName("order_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Notify).HasColumnName("notify");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");
            });

            modelBuilder.Entity<OcOrderOption>(entity =>
            {
                entity.HasKey(e => e.OrderOptionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_option");

                entity.Property(e => e.OrderOptionId).HasColumnName("order_option_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcOrderProduct>(entity =>
            {
                entity.HasKey(e => e.OrderProductId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_product");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Reward).HasColumnName("reward");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("tax");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<OcOrderRecurring>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_recurring");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.RecurringCycle).HasColumnName("recurring_cycle");

                entity.Property(e => e.RecurringDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_description");

                entity.Property(e => e.RecurringDuration).HasColumnName("recurring_duration");

                entity.Property(e => e.RecurringFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("recurring_frequency");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.RecurringName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_name");

                entity.Property(e => e.RecurringPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("recurring_price");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");

                entity.Property(e => e.Trial).HasColumnName("trial");

                entity.Property(e => e.TrialCycle).HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration).HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("trial_price");
            });

            modelBuilder.Entity<OcOrderRecurringTransaction>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringTransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_recurring_transaction");

                entity.Property(e => e.OrderRecurringTransactionId).HasColumnName("order_recurring_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OcOrderShipment>(entity =>
            {
                entity.HasKey(e => e.OrderShipmentId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_shipment");

                entity.Property(e => e.OrderShipmentId).HasColumnName("order_shipment_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ShippingCourierId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tracking_number")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OcOrderSimpleField>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_simple_fields");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Metadata).HasColumnName("metadata");

                entity.Property(e => e.PaymentField20).HasColumnName("payment_field20");

                entity.Property(e => e.PaymentField21).HasColumnName("payment_field21");

                entity.Property(e => e.PaymentField22).HasColumnName("payment_field22");

                entity.Property(e => e.ShippingField20).HasColumnName("shipping_field20");

                entity.Property(e => e.ShippingField21).HasColumnName("shipping_field21");

                entity.Property(e => e.ShippingField22).HasColumnName("shipping_field22");
            });

            modelBuilder.Entity<OcOrderStatus>(entity =>
            {
                entity.HasKey(e => new { e.OrderStatusId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_status");

                entity.Property(e => e.OrderStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("order_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcOrderTotal>(entity =>
            {
                entity.HasKey(e => e.OrderTotalId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_total");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderTotalId).HasColumnName("order_total_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcOrderVoucher>(entity =>
            {
                entity.HasKey(e => e.OrderVoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_order_voucher");

                entity.Property(e => e.OrderVoucherId).HasColumnName("order_voucher_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("from_email");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("to_email");

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("to_name");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");
            });

            modelBuilder.Entity<OcProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateAvailable)
                    .HasColumnType("date")
                    .HasColumnName("date_available")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("height");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("isbn");

                entity.Property(e => e.Jan)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("jan");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("length");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("location");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Minimum)
                    .HasColumnName("minimum")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Mpn)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("mpn");

                entity.Property(e => e.OctStickers)
                    .IsRequired()
                    .HasColumnName("oct_stickers");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shipping)
                    .IsRequired()
                    .HasColumnName("shipping")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sku");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockStatusId).HasColumnName("stock_status_id");

                entity.Property(e => e.Subtract)
                    .IsRequired()
                    .HasColumnName("subtract")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("upc");

                entity.Property(e => e.Viewed).HasColumnName("viewed");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<OcProductAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.AttributeId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_attribute");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcProductDescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<OcProductDiscount>(entity =>
            {
                entity.HasKey(e => e.ProductDiscountId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_discount");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductDiscountId).HasColumnName("product_discount_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<OcProductFilter>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.FilterId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_filter");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OcProductImage>(entity =>
            {
                entity.HasKey(e => e.ProductImageId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_image");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductImageId).HasColumnName("product_image_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OcProductOption>(entity =>
            {
                entity.HasKey(e => e.ProductOptionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_option");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcProductOptionValue>(entity =>
            {
                entity.HasKey(e => e.ProductOptionValueId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_option_value");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.PointsPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("points_prefix");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.PricePrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("price_prefix");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Subtract).HasColumnName("subtract");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightPrefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("weight_prefix");
            });

            modelBuilder.Entity<OcProductRecurring>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RecurringId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_recurring");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OcProductRelated>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RelatedId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_related");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RelatedId).HasColumnName("related_id");
            });

            modelBuilder.Entity<OcProductReward>(entity =>
            {
                entity.HasKey(e => e.ProductRewardId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_reward");

                entity.Property(e => e.ProductRewardId).HasColumnName("product_reward_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcProductSpecial>(entity =>
            {
                entity.HasKey(e => e.ProductSpecialId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_special");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductSpecialId).HasColumnName("product_special_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OcProductToCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_to_category");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.MainCategory).HasColumnName("main_category");
            });

            modelBuilder.Entity<OcProductToDownload>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DownloadId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_to_download");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");
            });

            modelBuilder.Entity<OcProductToLayout>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_to_layout");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OcProductToStore>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_product_to_store");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcRecurring>(entity =>
            {
                entity.HasKey(e => e.RecurringId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_recurring");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.Cycle)
                    .HasColumnType("int unsigned")
                    .HasColumnName("cycle");

                entity.Property(e => e.Duration)
                    .HasColumnType("int unsigned")
                    .HasColumnName("duration");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnType("enum('day','week','semi_month','month','year')")
                    .HasColumnName("frequency");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("price");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");

                entity.Property(e => e.TrialCycle)
                    .HasColumnType("int unsigned")
                    .HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration)
                    .HasColumnType("int unsigned")
                    .HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasColumnType("enum('day','week','semi_month','month','year')")
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("trial_price");

                entity.Property(e => e.TrialStatus)
                    .HasColumnType("tinyint")
                    .HasColumnName("trial_status");
            });

            modelBuilder.Entity<OcRecurringDescription>(entity =>
            {
                entity.HasKey(e => new { e.RecurringId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_recurring_description");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_return");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.DateOrdered)
                    .HasColumnType("date")
                    .HasColumnName("date_ordered")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Opened).HasColumnName("opened");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReturnActionId).HasColumnName("return_action_id");

                entity.Property(e => e.ReturnReasonId).HasColumnName("return_reason_id");

                entity.Property(e => e.ReturnStatusId).HasColumnName("return_status_id");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OcReturnAction>(entity =>
            {
                entity.HasKey(e => new { e.ReturnActionId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_return_action");

                entity.Property(e => e.ReturnActionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_action_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturnHistory>(entity =>
            {
                entity.HasKey(e => e.ReturnHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_return_history");

                entity.Property(e => e.ReturnHistoryId).HasColumnName("return_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Notify).HasColumnName("notify");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.ReturnStatusId).HasColumnName("return_status_id");
            });

            modelBuilder.Entity<OcReturnReason>(entity =>
            {
                entity.HasKey(e => new { e.ReturnReasonId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_return_reason");

                entity.Property(e => e.ReturnReasonId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_reason_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReturnStatus>(entity =>
            {
                entity.HasKey(e => new { e.ReturnStatusId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_return_status");

                entity.Property(e => e.ReturnStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("return_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_review");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Reply)
                    .IsRequired()
                    .HasColumnName("reply");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OcSeoUrl>(entity =>
            {
                entity.HasKey(e => e.SeoUrlId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_seo_url");

                entity.HasIndex(e => e.Keyword, "keyword");

                entity.HasIndex(e => e.Query, "query");

                entity.Property(e => e.SeoUrlId).HasColumnName("seo_url_id");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("query");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OcSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_session");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("data");

                entity.Property(e => e.Expire).HasColumnName("expire");
            });

            modelBuilder.Entity<OcSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_setting");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("code");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("key");

                entity.Property(e => e.Serialized).HasColumnName("serialized");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcShippingCourier>(entity =>
            {
                entity.HasKey(e => e.ShippingCourierId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_shipping_courier");

                entity.Property(e => e.ShippingCourierId).HasColumnName("shipping_courier_id");

                entity.Property(e => e.ShippingCourierCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_code")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShippingCourierName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OcSimpleCart>(entity =>
            {
                entity.HasKey(e => e.SimpleCartId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_simple_cart");

                entity.Property(e => e.SimpleCartId).HasColumnName("simple_cart_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Products).HasColumnName("products");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(32)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OcStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_statistics");

                entity.Property(e => e.StatisticsId).HasColumnName("statistics_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcStockStatus>(entity =>
            {
                entity.HasKey(e => new { e.StockStatusId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_stock_status");

                entity.Property(e => e.StockStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("stock_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcStore>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_store");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Ssl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ssl");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<OcTaxClass>(entity =>
            {
                entity.HasKey(e => e.TaxClassId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_tax_class");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OcTaxRate>(entity =>
            {
                entity.HasKey(e => e.TaxRateId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_tax_rate");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("rate");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OcTaxRateToCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.TaxRateId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_tax_rate_to_customer_group");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OcTaxRule>(entity =>
            {
                entity.HasKey(e => e.TaxRuleId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_tax_rule");

                entity.Property(e => e.TaxRuleId).HasColumnName("tax_rule_id");

                entity.Property(e => e.Based)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("based");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");
            });

            modelBuilder.Entity<OcTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_theme");

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("theme");
            });

            modelBuilder.Entity<OcTranslation>(entity =>
            {
                entity.HasKey(e => e.TranslationId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_translation");

                entity.Property(e => e.TranslationId).HasColumnName("translation_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("key");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcUpload>(entity =>
            {
                entity.HasKey(e => e.UploadId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_upload");

                entity.Property(e => e.UploadId).HasColumnName("upload_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OcUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_user_group");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<OcVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_voucher");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("from_email");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("to_email");

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("to_name");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");
            });

            modelBuilder.Entity<OcVoucherHistory>(entity =>
            {
                entity.HasKey(e => e.VoucherHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_voucher_history");

                entity.Property(e => e.VoucherHistoryId).HasColumnName("voucher_history_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");
            });

            modelBuilder.Entity<OcVoucherTheme>(entity =>
            {
                entity.HasKey(e => e.VoucherThemeId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_voucher_theme");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<OcVoucherThemeDescription>(entity =>
            {
                entity.HasKey(e => new { e.VoucherThemeId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_voucher_theme_description");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OcWeightClass>(entity =>
            {
                entity.HasKey(e => e.WeightClassId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_weight_class");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OcWeightClassDescription>(entity =>
            {
                entity.HasKey(e => new { e.WeightClassId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("oc_weight_class_description");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<OcZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_zone");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OcZoneToGeoZone>(entity =>
            {
                entity.HasKey(e => e.ZoneToGeoZoneId)
                    .HasName("PRIMARY");

                entity.ToTable("oc_zone_to_geo_zone");

                entity.Property(e => e.ZoneToGeoZoneId).HasColumnName("zone_to_geo_zone_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.GeoZoneId).HasColumnName("geo_zone_id");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            return modelBuilder;
        }
    }
}
