using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MigratonName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attribut__9090C9BB8A57364F", x => x.attribute_id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    car_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    mileage = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    engine_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    transmission = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fuel_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    body_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sale_location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cars__4C9A0DB3BE02DE50", x => x.car_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__D54EE9B43B46C16A", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCenters",
                columns: table => new
                {
                    center_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ServiceC__290A28879391C003", x => x.center_id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    tag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tags__4296A2B6EEC6A8F5", x => x.tag_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password_hash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    registration_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B9BE370F12055DB6", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "CarAttribute",
                columns: table => new
                {
                    car_id = table.Column<int>(type: "int", nullable: false),
                    attribute_id = table.Column<int>(type: "int", nullable: false),
                    value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarAttri__E5930128B9663F86", x => new { x.car_id, x.attribute_id });
                    table.ForeignKey(
                        name: "FK__CarAttrib__attri__0F624AF8",
                        column: x => x.attribute_id,
                        principalTable: "Attribute",
                        principalColumn: "attribute_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CarAttrib__car_i__0E6E26BF",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    image_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarImage__DC9AC95519BCAF5F", x => x.image_id);
                    table.ForeignKey(
                        name: "FK__CarImages__car_i__75A278F5",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceServices",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    center_id = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maintena__3E0DB8AFE7B2C252", x => x.service_id);
                    table.ForeignKey(
                        name: "FK__Maintenan__cente__6FE99F9F",
                        column: x => x.center_id,
                        principalTable: "ServiceCenters",
                        principalColumn: "center_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalMaintenance",
                columns: table => new
                {
                    maintenance_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    service_center_id = table.Column<int>(type: "int", nullable: true),
                    maintenance_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Technica__9D754BEA6F137B63", x => x.maintenance_id);
                    table.ForeignKey(
                        name: "FK__Technical__car_i__08B54D69",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Technical__servi__09A971A2",
                        column: x => x.service_center_id,
                        principalTable: "ServiceCenters",
                        principalColumn: "center_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CarRentals",
                columns: table => new
                {
                    rental_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    price_per_day = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarRenta__67DB611B7353CAD6", x => x.rental_id);
                    table.ForeignKey(
                        name: "FK__CarRental__car_i__5DCAEF64",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CarRental__user___5EBF139D",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarSales",
                columns: table => new
                {
                    sale_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    seller_id = table.Column<int>(type: "int", nullable: true),
                    buyer_id = table.Column<int>(type: "int", nullable: true),
                    sale_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarSales__E1EB00B2EBEC00BD", x => x.sale_id);
                    table.ForeignKey(
                        name: "FK__CarSales__buyer___6477ECF3",
                        column: x => x.buyer_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "FK__CarSales__car_id__628FA481",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CarSales__seller__6383C8BA",
                        column: x => x.seller_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRecords",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    service_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maintena__BFCFB4DD25F22D52", x => x.record_id);
                    table.ForeignKey(
                        name: "FK__Maintenan__car_i__693CA210",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Maintenan__user___6A30C649",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    notification_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    is_read = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__E059842FB1D383D0", x => x.notification_id);
                    table.ForeignKey(
                        name: "FK__Notificat__user___7F2BE32F",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publication_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    author_id = table.Column<int>(type: "int", nullable: true),
                    post_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Posts__3ED787661F40F73B", x => x.post_id);
                    table.ForeignKey(
                        name: "FK__Posts__author_id__4222D4EF",
                        column: x => x.author_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Posts__car_id__440B1D61",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Posts__category___44FF419A",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    profile_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birth_date = table.Column<DateOnly>(type: "date", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserProf__AEBB701FD54D881A", x => x.profile_id);
                    table.ForeignKey(
                        name: "FK__UserProfi__user___72C60C4A",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publication_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    post_id = table.Column<int>(type: "int", nullable: true),
                    post_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comments__E7957687DAB9DA3D", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK__Comments__post_i__59FA5E80",
                        column: x => x.post_id,
                        principalTable: "Posts",
                        principalColumn: "post_id");
                    table.ForeignKey(
                        name: "FK__Comments__user_i__59063A47",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertRecommendations",
                columns: table => new
                {
                    recommendation_id = table.Column<int>(type: "int", nullable: false),
                    expert_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ExpertRe__BCB11F4F42E1DD85", x => x.recommendation_id);
                    table.ForeignKey(
                        name: "FK__ExpertRec__car_i__5535A963",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id");
                    table.ForeignKey(
                        name: "FK__ExpertRec__exper__5441852A",
                        column: x => x.expert_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "FK__ExpertRec__recom__534D60F1",
                        column: x => x.recommendation_id,
                        principalTable: "Posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__News__4C27CCD8ADF27A17", x => x.news_id);
                    table.ForeignKey(
                        name: "FK__News__category_i__48CFD27E",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__News__news_id__47DBAE45",
                        column: x => x.news_id,
                        principalTable: "Posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    post_tag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_id = table.Column<int>(type: "int", nullable: true),
                    tag_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PostTags__FB97556E7117B25A", x => x.post_tag_id);
                    table.ForeignKey(
                        name: "FK__PostTags__post_i__7B5B524B",
                        column: x => x.post_id,
                        principalTable: "Posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__PostTags__tag_id__7C4F7684",
                        column: x => x.tag_id,
                        principalTable: "Tags",
                        principalColumn: "tag_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    rating_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    post_id = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ratings__D35B278BE756F034", x => x.rating_id);
                    table.ForeignKey(
                        name: "FK__Ratings__post_id__04E4BC85",
                        column: x => x.post_id,
                        principalTable: "Posts",
                        principalColumn: "post_id");
                    table.ForeignKey(
                        name: "FK__Ratings__user_id__03F0984C",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false),
                    car_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__60883D901AE0347B", x => x.review_id);
                    table.ForeignKey(
                        name: "FK__Reviews__car_id__4CA06362",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id");
                    table.ForeignKey(
                        name: "FK__Reviews__review___4BAC3F29",
                        column: x => x.review_id,
                        principalTable: "Posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestDrives",
                columns: table => new
                {
                    test_drive_id = table.Column<int>(type: "int", nullable: false),
                    car_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TestDriv__7AC61E305DBD24B6", x => x.test_drive_id);
                    table.ForeignKey(
                        name: "FK__TestDrive__car_i__5070F446",
                        column: x => x.car_id,
                        principalTable: "Cars",
                        principalColumn: "car_id");
                    table.ForeignKey(
                        name: "FK__TestDrive__test___4F7CD00D",
                        column: x => x.test_drive_id,
                        principalTable: "Posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarAttribute_attribute_id",
                table: "CarAttribute",
                column: "attribute_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_car_id",
                table: "CarImages",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarRentals_car_id",
                table: "CarRentals",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarRentals_user_id",
                table: "CarRentals",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_buyer_id",
                table: "CarSales",
                column: "buyer_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_car_id",
                table: "CarSales",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_seller_id",
                table: "CarSales",
                column: "seller_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Categori__72E12F1B64191FEB",
                table: "Categories",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_post_id",
                table: "Comments",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_user_id",
                table: "Comments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRecommendations_car_id",
                table: "ExpertRecommendations",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRecommendations_expert_id",
                table: "ExpertRecommendations",
                column: "expert_id");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_car_id",
                table: "MaintenanceRecords",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_user_id",
                table: "MaintenanceRecords",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceServices_center_id",
                table: "MaintenanceServices",
                column: "center_id");

            migrationBuilder.CreateIndex(
                name: "IX_News_category_id",
                table: "News",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_user_id",
                table: "Notifications",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_author_id",
                table: "Posts",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_car_id",
                table: "Posts",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_category_id",
                table: "Posts",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_post_id",
                table: "PostTags",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_tag_id",
                table: "PostTags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_post_id",
                table: "Ratings",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_user_id",
                table: "Ratings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_car_id",
                table: "Reviews",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "UQ__ServiceC__AB6E61648E4A03C8",
                table: "ServiceCenters",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Tags__72E12F1B2370C669",
                table: "Tags",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalMaintenance_car_id",
                table: "TechnicalMaintenance",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalMaintenance_service_center_id",
                table: "TechnicalMaintenance",
                column: "service_center_id");

            migrationBuilder.CreateIndex(
                name: "IX_TestDrives_car_id",
                table: "TestDrives",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_user_id",
                table: "UserProfiles",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__AB6E61642F096CF4",
                table: "Users",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarAttribute");

            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "CarRentals");

            migrationBuilder.DropTable(
                name: "CarSales");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertRecommendations");

            migrationBuilder.DropTable(
                name: "MaintenanceRecords");

            migrationBuilder.DropTable(
                name: "MaintenanceServices");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "TechnicalMaintenance");

            migrationBuilder.DropTable(
                name: "TestDrives");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "ServiceCenters");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
