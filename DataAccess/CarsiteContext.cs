using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CarsiteContext : DbContext
{
    public CarsiteContext()
    {
    }

    public CarsiteContext(DbContextOptions<CarsiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarAttribute> CarAttributes { get; set; }

    public virtual DbSet<CarImage> CarImages { get; set; }

    public virtual DbSet<CarRental> CarRentals { get; set; }

    public virtual DbSet<CarSale> CarSales { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<ExpertRecommendation> ExpertRecommendations { get; set; }

    public virtual DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }

    public virtual DbSet<MaintenanceService> MaintenanceServices { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostTag> PostTags { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<ServiceCenter> ServiceCenters { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TechnicalMaintenance> TechnicalMaintenances { get; set; }

    public virtual DbSet<TestDrife> TestDrives { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attribute>(entity =>
        {
            entity.HasKey(e => e.AttributeId).HasName("PK__Attribut__9090C9BB8A57364F");

            entity.ToTable("Attribute");

            entity.Property(e => e.AttributeId).HasColumnName("attribute_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.TypeValue)
                .HasMaxLength(50)
                .HasColumnName("type_value");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Cars__4C9A0DB3BE02DE50");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("body_type");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.EngineType)
                .HasMaxLength(50)
                .HasColumnName("engine_type");
            entity.Property(e => e.FuelType)
                .HasMaxLength(50)
                .HasColumnName("fuel_type");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");
            entity.Property(e => e.Make)
                .HasMaxLength(50)
                .HasColumnName("make");
            entity.Property(e => e.Mileage).HasColumnName("mileage");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.SaleLocation)
                .HasMaxLength(255)
                .HasColumnName("sale_location");
            entity.Property(e => e.Transmission)
                .HasMaxLength(50)
                .HasColumnName("transmission");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<CarAttribute>(entity =>
        {
            entity.HasKey(e => new { e.CarId, e.AttributeId }).HasName("PK__CarAttri__E5930128B9663F86");

            entity.ToTable("CarAttribute");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.AttributeId).HasColumnName("attribute_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Attribute).WithMany(p => p.CarAttributes)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK__CarAttrib__attri__0F624AF8");

            entity.HasOne(d => d.Car).WithMany(p => p.CarAttributes)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__CarAttrib__car_i__0E6E26BF");
        });

        modelBuilder.Entity<CarImage>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__CarImage__DC9AC95519BCAF5F");

            entity.Property(e => e.ImageId).HasColumnName("image_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");

            entity.HasOne(d => d.Car).WithMany(p => p.CarImages)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CarImages__car_i__75A278F5");
        });

        modelBuilder.Entity<CarRental>(entity =>
        {
            entity.HasKey(e => e.RentalId).HasName("PK__CarRenta__67DB611B7353CAD6");

            entity.Property(e => e.RentalId).HasColumnName("rental_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.PricePerDay)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price_per_day");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Car).WithMany(p => p.CarRentals)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CarRental__car_i__5DCAEF64");

            entity.HasOne(d => d.User).WithMany(p => p.CarRentals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CarRental__user___5EBF139D");
        });

        modelBuilder.Entity<CarSale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__CarSales__E1EB00B2EBEC00BD");

            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.BuyerId).HasColumnName("buyer_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.SaleDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sale_date");
            entity.Property(e => e.SellerId).HasColumnName("seller_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");

            entity.HasOne(d => d.Buyer).WithMany(p => p.CarSaleBuyers)
                .HasForeignKey(d => d.BuyerId)
                .HasConstraintName("FK__CarSales__buyer___6477ECF3");

            entity.HasOne(d => d.Car).WithMany(p => p.CarSales)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CarSales__car_id__628FA481");

            entity.HasOne(d => d.Seller).WithMany(p => p.CarSaleSellers)
                .HasForeignKey(d => d.SellerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CarSales__seller__6383C8BA");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__D54EE9B43B46C16A");

            entity.HasIndex(e => e.Name, "UQ__Categori__72E12F1B64191FEB").IsUnique();

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__Comments__E7957687DAB9DA3D");

            entity.Property(e => e.CommentId).HasColumnName("comment_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasColumnName("post_type");
            entity.Property(e => e.PublicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("publication_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__Comments__post_i__59FA5E80");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Comments__user_i__59063A47");
        });

        modelBuilder.Entity<ExpertRecommendation>(entity =>
        {
            entity.HasKey(e => e.RecommendationId).HasName("PK__ExpertRe__BCB11F4F42E1DD85");

            entity.Property(e => e.RecommendationId)
                .ValueGeneratedNever()
                .HasColumnName("recommendation_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.ExpertId).HasColumnName("expert_id");

            entity.HasOne(d => d.Car).WithMany(p => p.ExpertRecommendations)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__ExpertRec__car_i__5535A963");

            entity.HasOne(d => d.Expert).WithMany(p => p.ExpertRecommendations)
                .HasForeignKey(d => d.ExpertId)
                .HasConstraintName("FK__ExpertRec__exper__5441852A");

            entity.HasOne(d => d.Recommendation).WithOne(p => p.ExpertRecommendation)
                .HasForeignKey<ExpertRecommendation>(d => d.RecommendationId)
                .HasConstraintName("FK__ExpertRec__recom__534D60F1");
        });

        modelBuilder.Entity<MaintenanceRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK__Maintena__BFCFB4DD25F22D52");

            entity.Property(e => e.RecordId).HasColumnName("record_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ServiceDate)
                .HasColumnType("datetime")
                .HasColumnName("service_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Car).WithMany(p => p.MaintenanceRecords)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Maintenan__car_i__693CA210");

            entity.HasOne(d => d.User).WithMany(p => p.MaintenanceRecords)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Maintenan__user___6A30C649");
        });

        modelBuilder.Entity<MaintenanceService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Maintena__3E0DB8AFE7B2C252");

            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.CenterId).HasColumnName("center_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");

            entity.HasOne(d => d.Center).WithMany(p => p.MaintenanceServices)
                .HasForeignKey(d => d.CenterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Maintenan__cente__6FE99F9F");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PK__News__4C27CCD8ADF27A17");

            entity.Property(e => e.NewsId)
                .ValueGeneratedNever()
                .HasColumnName("news_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.HasOne(d => d.Category).WithMany(p => p.News)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__News__category_i__48CFD27E");

            entity.HasOne(d => d.NewsNavigation).WithOne(p => p.News)
                .HasForeignKey<News>(d => d.NewsId)
                .HasConstraintName("FK__News__news_id__47DBAE45");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__E059842FB1D383D0");

            entity.Property(e => e.NotificationId).HasColumnName("notification_id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IsRead)
                .HasDefaultValue(false)
                .HasColumnName("is_read");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Notificat__user___7F2BE32F");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Posts__3ED787661F40F73B");

            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasColumnName("post_type");
            entity.Property(e => e.PublicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("publication_date");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Author).WithMany(p => p.Posts)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Posts__author_id__4222D4EF");

            entity.HasOne(d => d.Car).WithMany(p => p.Posts)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Posts__car_id__440B1D61");

            entity.HasOne(d => d.Category).WithMany(p => p.Posts)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Posts__category___44FF419A");
        });

        modelBuilder.Entity<PostTag>(entity =>
        {
            entity.HasKey(e => e.PostTagId).HasName("PK__PostTags__FB97556E7117B25A");

            entity.Property(e => e.PostTagId).HasColumnName("post_tag_id");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.HasOne(d => d.Post).WithMany(p => p.PostTags)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PostTags__post_i__7B5B524B");

            entity.HasOne(d => d.Tag).WithMany(p => p.PostTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PostTags__tag_id__7C4F7684");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("PK__Ratings__D35B278BE756F034");

            entity.Property(e => e.RatingId).HasColumnName("rating_id");
            entity.Property(e => e.PostId).HasColumnName("post_id");
            entity.Property(e => e.Rating1).HasColumnName("rating");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Post).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__Ratings__post_id__04E4BC85");

            entity.HasOne(d => d.User).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Ratings__user_id__03F0984C");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__60883D901AE0347B");

            entity.Property(e => e.ReviewId)
                .ValueGeneratedNever()
                .HasColumnName("review_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");

            entity.HasOne(d => d.Car).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__Reviews__car_id__4CA06362");

            entity.HasOne(d => d.ReviewNavigation).WithOne(p => p.Review)
                .HasForeignKey<Review>(d => d.ReviewId)
                .HasConstraintName("FK__Reviews__review___4BAC3F29");
        });

        modelBuilder.Entity<ServiceCenter>(entity =>
        {
            entity.HasKey(e => e.CenterId).HasName("PK__ServiceC__290A28879391C003");

            entity.HasIndex(e => e.Email, "UQ__ServiceC__AB6E61648E4A03C8").IsUnique();

            entity.Property(e => e.CenterId).HasColumnName("center_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__Tags__4296A2B6EEC6A8F5");

            entity.HasIndex(e => e.Name, "UQ__Tags__72E12F1B2370C669").IsUnique();

            entity.Property(e => e.TagId).HasColumnName("tag_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TechnicalMaintenance>(entity =>
        {
            entity.HasKey(e => e.MaintenanceId).HasName("PK__Technica__9D754BEA6F137B63");

            entity.ToTable("TechnicalMaintenance");

            entity.Property(e => e.MaintenanceId).HasColumnName("maintenance_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.MaintenanceDate)
                .HasColumnType("datetime")
                .HasColumnName("maintenance_date");
            entity.Property(e => e.ServiceCenterId).HasColumnName("service_center_id");

            entity.HasOne(d => d.Car).WithMany(p => p.TechnicalMaintenances)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Technical__car_i__08B54D69");

            entity.HasOne(d => d.ServiceCenter).WithMany(p => p.TechnicalMaintenances)
                .HasForeignKey(d => d.ServiceCenterId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Technical__servi__09A971A2");
        });

        modelBuilder.Entity<TestDrife>(entity =>
        {
            entity.HasKey(e => e.TestDriveId).HasName("PK__TestDriv__7AC61E305DBD24B6");

            entity.Property(e => e.TestDriveId)
                .ValueGeneratedNever()
                .HasColumnName("test_drive_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");

            entity.HasOne(d => d.Car).WithMany(p => p.TestDrives)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__TestDrive__car_i__5070F446");

            entity.HasOne(d => d.TestDrive).WithOne(p => p.TestDrife)
                .HasForeignKey<TestDrife>(d => d.TestDriveId)
                .HasConstraintName("FK__TestDrive__test___4F7CD00D");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F12055DB6");

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E61642F096CF4").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("registration_date");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__UserProf__AEBB701FD54D881A");

            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Bio).HasColumnName("bio");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__UserProfi__user___72C60C4A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
