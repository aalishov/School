using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P02_Eventures.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Place = table.Column<string>(maxLength: 100, nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    TotalTickets = table.Column<int>(nullable: false),
                    PricePerTicket = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderedOn = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    EventId = table.Column<string>(nullable: true),
                    TicketsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2654527-827f-491e-94c9-7ddb8d316281", "462e5917-a6ac-4512-9354-e9140b783fa1", "Admin", "Admin" },
                    { "491dc564-0462-475f-8c53-3e03f84d3fdf", "4eef99a0-4dad-4550-a091-7b8974c7a511", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05de56c2-1744-4b45-bcf0-4c26f89115ca", 0, "0d810952-9a51-4cc8-96f6-b0258a1bbad8", "user71@abv.bg", false, null, null, false, null, "user71@abv.bg", "user71@abv.bg", "AQAAAAEAACcQAAAAEP3RKB/8FndRcI6GIugByDfIVX6zAiXAxvAu5p0gMpbBjywpITEsKzwdX+Az59bdxA==", null, false, "", false, "user71@abv.bg" },
                    { "85dd1248-73f2-425d-b72f-8c5cd6f34432", 0, "7cad4297-c711-4f08-99c3-336328260990", "user70@abv.bg", false, null, null, false, null, "user70@abv.bg", "user70@abv.bg", "AQAAAAEAACcQAAAAEBsq82rCxyY+jhalyeI1nWHPFQwQnbZxblDv/mvS4/QfTJosaix2/TQ8NdWfT2m4+w==", null, false, "", false, "user70@abv.bg" },
                    { "22d67832-b157-4a91-b9ac-a1bc3abce5cb", 0, "1d49d4dd-8bb6-4d78-90bc-82f5e3e7b114", "user69@abv.bg", false, null, null, false, null, "user69@abv.bg", "user69@abv.bg", "AQAAAAEAACcQAAAAEOnzQ1bqju55tQZg6EPfk9pbeN0ajhP7Cy6ePKLMgB4XSAuoNoHFu7vqGelXQz49gg==", null, false, "", false, "user69@abv.bg" },
                    { "ee7212a1-0122-467b-bc52-74b82a3f1910", 0, "1f733a89-fcd8-4417-bfa9-6e34271730d1", "user68@abv.bg", false, null, null, false, null, "user68@abv.bg", "user68@abv.bg", "AQAAAAEAACcQAAAAEEjhpDYuQTLsabfcoCJvEJnzf35kU6AW9xIV6j/1GCIY8gfQMygZZvV6RHZEDoJYoA==", null, false, "", false, "user68@abv.bg" },
                    { "28c82f51-a307-4a39-abd7-9c7e948043c6", 0, "cc783e7d-6823-4626-ad84-a5077ca42562", "user67@abv.bg", false, null, null, false, null, "user67@abv.bg", "user67@abv.bg", "AQAAAAEAACcQAAAAEC37g89hqc9FRg22No/htrYPrBXoOHGxpzoPAxVTnk846uYt7yQ83akG4Ge6KusZAw==", null, false, "", false, "user67@abv.bg" },
                    { "bf0eeacd-8397-4faa-b022-67422f37f364", 0, "925feff2-5905-4aa8-a18d-480d50a24271", "user66@abv.bg", false, null, null, false, null, "user66@abv.bg", "user66@abv.bg", "AQAAAAEAACcQAAAAEDPex/YAit6wRUhprCdQX+aKeGQkvnImtQzj4NlO1glwEaDKQ6ILYewA8uofE9xucA==", null, false, "", false, "user66@abv.bg" },
                    { "0d556737-881d-4eef-aa4f-4b9e9c1ed59b", 0, "ad61fb6e-1c8d-42eb-9f81-549509a4262a", "user65@abv.bg", false, null, null, false, null, "user65@abv.bg", "user65@abv.bg", "AQAAAAEAACcQAAAAEMjh1kddpd1SlxtSl+bIBLs1jQ3WFTv9O36ugJHBQhrD+AMbIVbb6lk/A4WTmo7DoA==", null, false, "", false, "user65@abv.bg" },
                    { "36770434-1c4e-4035-a67b-47f872d1e8bc", 0, "2be1a78d-b7dd-43f9-a4ac-9c8946470ade", "user64@abv.bg", false, null, null, false, null, "user64@abv.bg", "user64@abv.bg", "AQAAAAEAACcQAAAAELyww8G0YsDladKyB3aOf/HChlrZL+ImWB1UzfxqFNFBxlUko9Un0LrpoZVCPxcnxg==", null, false, "", false, "user64@abv.bg" },
                    { "bd95ef3d-f544-4f5c-b635-ee756447a4d8", 0, "13958ef5-17ce-439b-9be5-93e280241143", "user63@abv.bg", false, null, null, false, null, "user63@abv.bg", "user63@abv.bg", "AQAAAAEAACcQAAAAENL7z2z5b9szVq39bDEtfYVtMAKVwQIgxOJmkNRPJSH85lWcmGJVFzI8TYfvp9/vbw==", null, false, "", false, "user63@abv.bg" },
                    { "ea841e97-898a-48ff-a2d7-599001f6fd10", 0, "591dfa9f-cf83-4006-abca-7cb9a2169b5a", "user62@abv.bg", false, null, null, false, null, "user62@abv.bg", "user62@abv.bg", "AQAAAAEAACcQAAAAEF110xKUm71wUhgCGIS0PKZHvUzu5hNOKCFJ6d+hiI82JFNyNXFWwdWnQyGu0p1lBg==", null, false, "", false, "user62@abv.bg" },
                    { "e78fd5a0-87cb-40c8-a2ce-4331257a4301", 0, "4398f6c2-c5ee-4851-acf6-b9ca53f78d17", "user61@abv.bg", false, null, null, false, null, "user61@abv.bg", "user61@abv.bg", "AQAAAAEAACcQAAAAEHF1F6yVxuNDrqkhrZw+aNg5funh/Zn5pnUQeXLujgdCp+VGrZsCddjs1c3msaKDMA==", null, false, "", false, "user61@abv.bg" },
                    { "8b525c36-b532-4cf0-a0d5-22d2e2dfd2d3", 0, "9384bfe8-4aeb-4895-b7e8-70d7d685a95e", "user60@abv.bg", false, null, null, false, null, "user60@abv.bg", "user60@abv.bg", "AQAAAAEAACcQAAAAEF09rQtDwTu8qXBXCfWpg9TEbh7FvZTeUmfZS25mef1IUbV2Q5X1CtOkX9Cp5Gf9yw==", null, false, "", false, "user60@abv.bg" },
                    { "32d01b93-b9c2-422c-a870-81b13e8364c7", 0, "530a26e1-2d67-406b-93ad-6a0f8362d1ac", "user59@abv.bg", false, null, null, false, null, "user59@abv.bg", "user59@abv.bg", "AQAAAAEAACcQAAAAELaTRDlzZgOwoCDGuTjxnaTTb0E6aBL5EnRzLFvXIB3do+Pc2+E5rM/5doHphM4XJA==", null, false, "", false, "user59@abv.bg" },
                    { "bf7d4ae5-8905-40ce-9f7e-e2389ddfe488", 0, "61168366-27af-47f4-9cf3-30b28a503861", "user58@abv.bg", false, null, null, false, null, "user58@abv.bg", "user58@abv.bg", "AQAAAAEAACcQAAAAEFVRgJcH6kat9W7lnCI8eh8k4r+DGIna1EtwR3mfa/JAkJCsL0UjH+y4H/SsH/uY6g==", null, false, "", false, "user58@abv.bg" },
                    { "74c185b9-8aae-4d6c-9089-e053b8ed82e4", 0, "22a3c6e2-c04d-4258-8fd6-95276e196c4b", "user57@abv.bg", false, null, null, false, null, "user57@abv.bg", "user57@abv.bg", "AQAAAAEAACcQAAAAEC0XfbAyFjmdr674d1Lra2pJCrO5l1gH7tFJKfEiJl275tSUo1d0KfnfZQoFwl68Tg==", null, false, "", false, "user57@abv.bg" },
                    { "0faa63da-ae8c-4252-96ce-e60731d31f02", 0, "083b9c21-434e-4b5f-8dab-bd7bfbb974dd", "user56@abv.bg", false, null, null, false, null, "user56@abv.bg", "user56@abv.bg", "AQAAAAEAACcQAAAAEBd07i5CCEiVgTk3XlvoHrZZQAhg930qvu9WG34a4/w0+D7UB9AY7HaRG4pgFPnlAA==", null, false, "", false, "user56@abv.bg" },
                    { "caa2d573-9668-4c4e-b09e-461bd8e1ee1e", 0, "cea9e153-0863-4a3e-b795-62e7f0164864", "user55@abv.bg", false, null, null, false, null, "user55@abv.bg", "user55@abv.bg", "AQAAAAEAACcQAAAAEICTEfhM4UlXGHlsEhEVg58Uig9Cyw8P57mmCaLvVDHA4wo1mhoyUyTD4D7V3DXJUQ==", null, false, "", false, "user55@abv.bg" },
                    { "25429f64-a636-4520-8b67-504ef23cd340", 0, "6cf4877c-9cb1-4e2b-a791-815cf71b3b1d", "user54@abv.bg", false, null, null, false, null, "user54@abv.bg", "user54@abv.bg", "AQAAAAEAACcQAAAAEPMLGncqjUHVaEaDaIP5QPtKIPl7PMl8XgSpmgkG3yaeJ/k7ELUv4QLIZfLG52R+xQ==", null, false, "", false, "user54@abv.bg" },
                    { "b31084f4-f95b-4dd8-ab1f-d19bd495ea2e", 0, "27dd8c85-af3c-413d-b888-871e2c323d76", "user53@abv.bg", false, null, null, false, null, "user53@abv.bg", "user53@abv.bg", "AQAAAAEAACcQAAAAEMUYR3fxP0myze+l0fLW+i83ZBTb2lYByyYzgoTUzYecr/aP0uj1dkH5aCAJxLrEhA==", null, false, "", false, "user53@abv.bg" },
                    { "7d8c163c-a400-45af-b8b7-c0ce5eb82d70", 0, "0d08128c-5ae6-4c56-9fc5-79dfaa3f6ee9", "user52@abv.bg", false, null, null, false, null, "user52@abv.bg", "user52@abv.bg", "AQAAAAEAACcQAAAAEGkS6U0WzlvWAZavu8cPpf1MbtXW+UxxJlc80k1I4+8l8UBiIQoR+MnwaMu4Bn0mlw==", null, false, "", false, "user52@abv.bg" },
                    { "73839d78-1861-4bde-a9a5-7462ae96e399", 0, "12f4e69a-4db6-4643-ae2b-08f70038e0f1", "user51@abv.bg", false, null, null, false, null, "user51@abv.bg", "user51@abv.bg", "AQAAAAEAACcQAAAAECXxljtFhCesXganExmjmaB31n1rbeJfBBftG19W5GbGaLVup5icGa45FhzmcYh4qg==", null, false, "", false, "user51@abv.bg" },
                    { "09322e5c-3d58-46db-ba0a-36bb26edc761", 0, "1946f9d4-ca36-4db5-a930-5f0bc0f608cc", "user72@abv.bg", false, null, null, false, null, "user72@abv.bg", "user72@abv.bg", "AQAAAAEAACcQAAAAEF25mzdXrgpWZV4KOEDbQkgh9gz05+UgBMlyzkGQT0cGw8mFUEKGVC0meL6WxShLtw==", null, false, "", false, "user72@abv.bg" },
                    { "581973d4-edff-4027-86fb-222c03dd5b68", 0, "87047113-126a-43ff-beed-d84e4876bf75", "user73@abv.bg", false, null, null, false, null, "user73@abv.bg", "user73@abv.bg", "AQAAAAEAACcQAAAAENYXsd8Sz3ZA5N8Q4iktF5s/zOQBKSEAHvccX9fYb4M7LaoSUEyb1m7pIf2TXnAInA==", null, false, "", false, "user73@abv.bg" },
                    { "6944b8ed-d73f-4819-86f9-05e1bb824345", 0, "7129f62f-b915-4c53-be35-ad1562b4848e", "user74@abv.bg", false, null, null, false, null, "user74@abv.bg", "user74@abv.bg", "AQAAAAEAACcQAAAAEDZnjAyZn+KPkuJVizIq2G7ovxxGiLHjUkre8ySM/gAxxHvbFSQ1BDh/UgyvIB8h0Q==", null, false, "", false, "user74@abv.bg" },
                    { "22423ba0-822a-40a5-bda0-21c7c0a83425", 0, "0e208518-5c37-44da-9bb6-2f9a23eb75c6", "user75@abv.bg", false, null, null, false, null, "user75@abv.bg", "user75@abv.bg", "AQAAAAEAACcQAAAAEFfxI7i5tiDr9vqcUbIS5kb3cIEliyBy3NYMd8YnH/603OX7ZoNvbMuUa1f5TS6yvg==", null, false, "", false, "user75@abv.bg" },
                    { "5dcc31a0-0824-4b0e-a011-722c1714968f", 0, "99fae7a7-bc53-4adc-a5f7-5e7d66e6746c", "user97@abv.bg", false, null, null, false, null, "user97@abv.bg", "user97@abv.bg", "AQAAAAEAACcQAAAAEDcAM1BTONjz/BYcZdbxAMPh66xEkjtJoE5YCjqozYuuGypuYh4+IGe5So0skbZYYw==", null, false, "", false, "user97@abv.bg" },
                    { "c05b1471-e855-4b79-bb33-b5bff6abf3ce", 0, "d7b19d71-e211-41c3-bd34-982fa7334ae3", "user96@abv.bg", false, null, null, false, null, "user96@abv.bg", "user96@abv.bg", "AQAAAAEAACcQAAAAECd/5WrM6W1eGKRZOdNaIILW7/MKJxVp+7elXWK69WrnNN2VFgmLvBWLiIf5nbeDfA==", null, false, "", false, "user96@abv.bg" },
                    { "82ed05a1-67c0-4b6d-85de-7c1b73407668", 0, "61c5fc77-60cf-4441-ba9e-e146181e2372", "user95@abv.bg", false, null, null, false, null, "user95@abv.bg", "user95@abv.bg", "AQAAAAEAACcQAAAAEHAx2qfdTpHmBn8QiRX89L1pp94087EoALRF/VUju6ZE/jr+BZ3h9mtGUBwFXNBnVQ==", null, false, "", false, "user95@abv.bg" },
                    { "c601aa9b-1c90-4321-9ed8-a3d7985565a5", 0, "0c796240-4460-421d-a5dc-6ba87b49ca2e", "user94@abv.bg", false, null, null, false, null, "user94@abv.bg", "user94@abv.bg", "AQAAAAEAACcQAAAAEIGT1kiDG5bz5bEPS2MIyeo+0brm66vOPJPFaSS4ekfOShzKsMn35kjyAFEgoGdzEA==", null, false, "", false, "user94@abv.bg" },
                    { "7192d4e3-6406-44c4-88bd-0c358e46cc0c", 0, "aee4ad33-738c-4ea0-aa34-782a49767438", "user93@abv.bg", false, null, null, false, null, "user93@abv.bg", "user93@abv.bg", "AQAAAAEAACcQAAAAEGIub1UMpZVNInx17z9bhkVOuOmSEnlhWXgueOOffVk1IJ9okk+EeJHgOWyE8gjyjA==", null, false, "", false, "user93@abv.bg" },
                    { "acb3b004-139f-410d-a48e-310c81ab1756", 0, "1cb35e89-fd72-468f-b7fa-d34d2570593a", "user92@abv.bg", false, null, null, false, null, "user92@abv.bg", "user92@abv.bg", "AQAAAAEAACcQAAAAELTWFdQVvaeFVzTc249rVNyEeAwKEZnFjcIGZfKKGJeu8/M9rYybbB+U7FxWyOlojA==", null, false, "", false, "user92@abv.bg" },
                    { "28fc329c-d8eb-46a3-b092-e5e2dbc7c8e5", 0, "fc19e727-f034-40a9-bbbe-657b9aeee9fc", "user91@abv.bg", false, null, null, false, null, "user91@abv.bg", "user91@abv.bg", "AQAAAAEAACcQAAAAEAflgRYMPgaTL4IP+VoDq641lOP9SoBldPQm0e7VtJqLwN+cBhpxSvJm9e9f3oig5Q==", null, false, "", false, "user91@abv.bg" },
                    { "0149f011-c289-4322-b1ea-7c7366c40c20", 0, "2269120c-76a3-4f28-a23c-b5bb0b7e5b2f", "user90@abv.bg", false, null, null, false, null, "user90@abv.bg", "user90@abv.bg", "AQAAAAEAACcQAAAAEFJ6dNBOvsZAj7LIXMOYxx4tPrTXArOt+foETdVfexcOtLojzhk/CRRL3iJFhAXLeg==", null, false, "", false, "user90@abv.bg" },
                    { "bafd8676-1ee8-405d-86b0-8626fdc662f2", 0, "42ed15c5-ba77-421b-a277-27cb26bdb21f", "user89@abv.bg", false, null, null, false, null, "user89@abv.bg", "user89@abv.bg", "AQAAAAEAACcQAAAAEETbEA5lbRasdE+pEL/qKntj17ZhSbDwKWXWhyKG4BV8X54viTecUlMD5l5fSlgBJw==", null, false, "", false, "user89@abv.bg" },
                    { "61e642f4-06b0-4e51-ba69-462f336dd4bb", 0, "29142337-6787-4d30-8ca1-354c264877cf", "user88@abv.bg", false, null, null, false, null, "user88@abv.bg", "user88@abv.bg", "AQAAAAEAACcQAAAAEKJQgH2MPBSLJju+YsGxLAPy92p9uDUiwckfGkea/A+xwFmy0TYOQnX3v9IoX+MQZA==", null, false, "", false, "user88@abv.bg" },
                    { "1f282963-5156-4a78-9afe-ec3d409f4790", 0, "90e46bc9-82f6-4db0-8261-48e04f142931", "user50@abv.bg", false, null, null, false, null, "user50@abv.bg", "user50@abv.bg", "AQAAAAEAACcQAAAAEN3O4Q7tDeMjcYa34ytzg27KTcwF1nyOPoYCgZbZPQ1RiKaxFsunvZfbfbuPViPNvw==", null, false, "", false, "user50@abv.bg" },
                    { "420abf51-4ef7-4845-b592-3ff9ae4f74a2", 0, "f26bfa68-e976-4c26-b1b4-beebe4c46c11", "user87@abv.bg", false, null, null, false, null, "user87@abv.bg", "user87@abv.bg", "AQAAAAEAACcQAAAAEFXe1c36eXDD0VFXIK4o0/zGEQWooGa5UgyGTcx8O/iy+1jb+NnKgsj9dSTycz2SUw==", null, false, "", false, "user87@abv.bg" },
                    { "3d6273d3-8efa-4c35-946c-3ea58d9efc82", 0, "11afb54d-1b41-43e8-8ae6-19613de7aede", "user85@abv.bg", false, null, null, false, null, "user85@abv.bg", "user85@abv.bg", "AQAAAAEAACcQAAAAEIw9eNKG/BW0nsjJfHEp2SebKd9NJRJuNDk1XYMimGuRw49TSYL9G7tPj2F92ySVUw==", null, false, "", false, "user85@abv.bg" },
                    { "10ddc1be-8f84-4624-8f24-a8056a90679d", 0, "2a2ea95e-b04c-40d9-99b5-84c40b271e42", "user84@abv.bg", false, null, null, false, null, "user84@abv.bg", "user84@abv.bg", "AQAAAAEAACcQAAAAEFo1PaBNhpUumiaPROlle3oZRbv/kKTtcSww59WGy4BwjQ7FOvQEMYFcnLPZ/wmHaA==", null, false, "", false, "user84@abv.bg" },
                    { "d25d1348-0d2b-46a1-a977-41cd825394e7", 0, "21fbd00d-1eba-4af1-b3a4-7f188cb0dc24", "user83@abv.bg", false, null, null, false, null, "user83@abv.bg", "user83@abv.bg", "AQAAAAEAACcQAAAAEEq2l8S6EimFsntmvH62kGAcq53Lt621ln3R+GWnTcznwUfiaRt2CBioV6doUL79Fw==", null, false, "", false, "user83@abv.bg" },
                    { "3fb0d047-892d-4892-9454-bcd0b758357f", 0, "8235c3d2-6e00-4701-abf5-e2305e080ade", "user82@abv.bg", false, null, null, false, null, "user82@abv.bg", "user82@abv.bg", "AQAAAAEAACcQAAAAEHe+nkFqkBlHXqL5EO/omkGXKKQfSb13jmSxI/9iaqO/RyJviOOgM2rna1K2zPz2Nw==", null, false, "", false, "user82@abv.bg" },
                    { "ad8b207f-1383-4e1b-aebf-d2a3e89a3830", 0, "82cd8294-cb64-456b-875d-5a1bf44f4eb9", "user81@abv.bg", false, null, null, false, null, "user81@abv.bg", "user81@abv.bg", "AQAAAAEAACcQAAAAEEPsPxaAvZ7CPYtmAfi/j6SLGfzHVfITtdNKOiCscrhmOOUHushuyVR+nZdf6MgJug==", null, false, "", false, "user81@abv.bg" },
                    { "93688c5b-3bb3-4dc0-a651-66601a946992", 0, "e98c291d-1443-42d3-8007-58ad1214016c", "user80@abv.bg", false, null, null, false, null, "user80@abv.bg", "user80@abv.bg", "AQAAAAEAACcQAAAAELWWY1vFEr43rVq4e0WxmT2mJ8Rb7jO/Tx4VJh4NVUclRu2M+wcViRRxJC5K5KX82w==", null, false, "", false, "user80@abv.bg" },
                    { "5b5cb67a-42d1-4480-ac87-805658611cbd", 0, "176ba13d-bbf5-48aa-a3fd-c7f0c7a9ae81", "user79@abv.bg", false, null, null, false, null, "user79@abv.bg", "user79@abv.bg", "AQAAAAEAACcQAAAAEBrfvmLDFlF8ufth5H1c0BR5Dkn7hvEkFxqrNAcsD6JYmuqQmpFBS2EQs5J8h65kPg==", null, false, "", false, "user79@abv.bg" },
                    { "411dad10-7f41-4f04-a7e4-bbc08ad9fe12", 0, "fea36681-ee63-4eed-8c86-169563925370", "user78@abv.bg", false, null, null, false, null, "user78@abv.bg", "user78@abv.bg", "AQAAAAEAACcQAAAAEE6HgbOQHOYwy+8S2Zg+ycafDjaOQcEUe/weA8EHPeA0lshLJZ3+olo8YXHOXOPtZQ==", null, false, "", false, "user78@abv.bg" },
                    { "6afdfe59-29a8-4bec-9399-2c37a2edba2a", 0, "ce504d89-f1e6-45db-aa5e-12d5982943d4", "user77@abv.bg", false, null, null, false, null, "user77@abv.bg", "user77@abv.bg", "AQAAAAEAACcQAAAAEEXcwqeFGmOuqi3o+nHlLZBXsfiN1Bbl53xbFH7Y9ULk71gEidqjXqQMSXnZNwvsrQ==", null, false, "", false, "user77@abv.bg" },
                    { "a9049e95-b8a7-4937-b0a2-b50f04c11d31", 0, "cda37b2b-d32c-4aae-afb4-022d1a1aea1b", "user76@abv.bg", false, null, null, false, null, "user76@abv.bg", "user76@abv.bg", "AQAAAAEAACcQAAAAEKirVokq8MxCpL/Ou7IJ5NejkySqoIDeZqBBw+LdvZ8rlXywLlCC9xl25s3Vwd3fAQ==", null, false, "", false, "user76@abv.bg" },
                    { "c1db2409-bcd4-4ba4-9637-86bf9919a28c", 0, "0c28a18a-5392-422a-840d-4219eef18867", "user86@abv.bg", false, null, null, false, null, "user86@abv.bg", "user86@abv.bg", "AQAAAAEAACcQAAAAEJcHZa9RQfUKMB3bu8uvQUqn2SaCcuezPwcNze7WsI8DMFOnYdG6gKy69vbqsmfpZQ==", null, false, "", false, "user86@abv.bg" },
                    { "59331a1a-1293-45b9-98f1-245ec064fff0", 0, "4a9103cf-f1ee-4068-9e15-0634edb0d983", "user49@abv.bg", false, null, null, false, null, "user49@abv.bg", "user49@abv.bg", "AQAAAAEAACcQAAAAEE1AVUrsl5rCyJWiOWrod8DB5n1sxZ487CuJD8tpQLO/9P8r+BVN/vpK2EW64TlnJw==", null, false, "", false, "user49@abv.bg" },
                    { "0991be9d-cb8d-4614-8b1c-ed4e298c8653", 0, "5662c891-1211-4a33-acaa-1df93f782e0d", "user48@abv.bg", false, null, null, false, null, "user48@abv.bg", "user48@abv.bg", "AQAAAAEAACcQAAAAEMxDmQNKjU3oTIAy1exhoLcRThH9a6993pQXHKXgD6Wi6aD7l+FieJejwG4DvT0Iqg==", null, false, "", false, "user48@abv.bg" },
                    { "bd6e4d5d-cb3a-431a-b9a6-a9dd8e8d72e2", 0, "cbdcf7a1-4dd1-4407-abc2-305c34c3891e", "user47@abv.bg", false, null, null, false, null, "user47@abv.bg", "user47@abv.bg", "AQAAAAEAACcQAAAAEIUIIU6LviNWU0d3/r3ArUzk6OvNnxOiMMtlDCZuowIkwh+C1jVxWyYjcNqUIwAxzg==", null, false, "", false, "user47@abv.bg" },
                    { "b64ac5a5-d9c7-4232-974c-45811065c097", 0, "07cbf7d7-eafc-405b-bc71-1a74f9de3d77", "user20@abv.bg", false, null, null, false, null, "user20@abv.bg", "user20@abv.bg", "AQAAAAEAACcQAAAAEIpmtDszo8fqKXvQAsevArj9HckzOJiOT4d5GnHC54hT7CaMiIxo1GHunv2qauxKdg==", null, false, "", false, "user20@abv.bg" },
                    { "b2945152-d6f1-4fef-ae01-cb976725c8c6", 0, "3e33479b-3739-4a6b-ae03-b651f26c9a0e", "user19@abv.bg", false, null, null, false, null, "user19@abv.bg", "user19@abv.bg", "AQAAAAEAACcQAAAAEDF3IAVDStYnPZ40fVWE8C2fuEUXTNMdnQDEceW/vqjvUKsj411+ptmoBmmwdHvm9A==", null, false, "", false, "user19@abv.bg" },
                    { "a53e5a13-f58c-42de-8731-9bc1ce77fc5d", 0, "9e1c80f9-0b27-4dfa-aae0-8d433d1cfca9", "user18@abv.bg", false, null, null, false, null, "user18@abv.bg", "user18@abv.bg", "AQAAAAEAACcQAAAAEIVm1bjhNGVY0DI64PBtyohQLBJ2tmhYoklRxL4aJWBolI4VYbBZtekZFt2/cb9QcQ==", null, false, "", false, "user18@abv.bg" },
                    { "ccda49ab-4b4c-4b7c-a2ac-082d945578b4", 0, "06806360-3c15-4dbd-a731-7664c6788489", "user17@abv.bg", false, null, null, false, null, "user17@abv.bg", "user17@abv.bg", "AQAAAAEAACcQAAAAEEMdnVCxOhIHc0lvqoJSH9dLGMENpOlMn4DarZ97npIYJn/3D4hPO4zgX9So6gtP+w==", null, false, "", false, "user17@abv.bg" },
                    { "1d82720c-8956-437b-973a-aa8cb0f9f730", 0, "aab2fc9d-9e1e-453e-b32c-aa9e06372890", "user16@abv.bg", false, null, null, false, null, "user16@abv.bg", "user16@abv.bg", "AQAAAAEAACcQAAAAEE7RtQovPZVUZnog0oLtqYrFM3LgrpPoWizjK+ayR3W6GQGafNurfzA0hQwQYFZPPQ==", null, false, "", false, "user16@abv.bg" },
                    { "d666a286-7ac1-49ac-bcb7-ef19f32e5f99", 0, "5ad45dc0-5651-4a2a-9815-b2b2b950ada6", "user15@abv.bg", false, null, null, false, null, "user15@abv.bg", "user15@abv.bg", "AQAAAAEAACcQAAAAEGxzvZ8G+Pa9Wp4gxU5qLlNP+AoGiyTwcuF/7mmYETb6M9SG+GW16WUdwUw6/Zlwsg==", null, false, "", false, "user15@abv.bg" },
                    { "04d3b90d-7fd1-4ed1-8174-26614a01285c", 0, "1185e5f1-9efe-4dab-b331-11d1105741e3", "user14@abv.bg", false, null, null, false, null, "user14@abv.bg", "user14@abv.bg", "AQAAAAEAACcQAAAAEFpF9UqFbA0Js4/AnsDIjH8iDi6VDI5wHtmbvou9yj08jXB/PxgAk9zqUN5X7nZA6g==", null, false, "", false, "user14@abv.bg" },
                    { "50a53241-c66b-4e3a-a535-755d4373f54d", 0, "ac7a783b-c784-44db-a8cf-00215ab04bfe", "user13@abv.bg", false, null, null, false, null, "user13@abv.bg", "user13@abv.bg", "AQAAAAEAACcQAAAAEAdfIas3gQh/0tBo6GZr6/qgWW8B0QBRxDPBkMVUadIgV16+lsli757pDsqCSfUWaw==", null, false, "", false, "user13@abv.bg" },
                    { "668002db-c12f-4611-bc59-87cc8011ca68", 0, "3e2326cd-8f6b-465c-82f8-4556f570dfbd", "user12@abv.bg", false, null, null, false, null, "user12@abv.bg", "user12@abv.bg", "AQAAAAEAACcQAAAAEESvvSyFhOJum9ULOm25UAmVvM51HqWegn76cSjMRRdM13HN4JsOS8TwIpDeEFJdbg==", null, false, "", false, "user12@abv.bg" },
                    { "d31fd758-dc6a-4a19-aa2d-d2ef339b0120", 0, "8c97bbbd-2dea-4402-9199-bd058f85965b", "user11@abv.bg", false, null, null, false, null, "user11@abv.bg", "user11@abv.bg", "AQAAAAEAACcQAAAAEFrvuVdEh1fBKdurgiyod6HesRJegUP1pRrEmZObgnU3Ypw1EMdnY0v225UJA3pHnA==", null, false, "", false, "user11@abv.bg" },
                    { "6853475f-1125-4aa1-80d3-1db786b769fa", 0, "29ab29a3-125d-4597-bfc2-ab3723b0aa52", "user21@abv.bg", false, null, null, false, null, "user21@abv.bg", "user21@abv.bg", "AQAAAAEAACcQAAAAEHheIPj5amApWwvYXxMwsP79TqadrZcIAyz+GNXmzALXSOR+AF+p6FRKLZ4TqrT0PA==", null, false, "", false, "user21@abv.bg" },
                    { "39d9892b-1744-4934-99e4-fcd5714f21ac", 0, "937bf200-1fd7-411c-8c30-afd7aae894f7", "user10@abv.bg", false, null, null, false, null, "user10@abv.bg", "user10@abv.bg", "AQAAAAEAACcQAAAAEMlkRPR+T/VWE7GkKUbe89XJcYfLNArWOpw0sU0XEGSGvrLXYgqaqENxVrAgh32VUw==", null, false, "", false, "user10@abv.bg" },
                    { "1bc945dc-39b4-46de-a6ef-1922fde3a969", 0, "14e20770-930e-445c-9f7a-d4b13b71357b", "user8@abv.bg", false, null, null, false, null, "user8@abv.bg", "user8@abv.bg", "AQAAAAEAACcQAAAAEB6rEeyFHmZimv063IIw1nMdW5VPPFTsmlnJ4KA4sAf/AVvsN0n5So5BGSXYzQoaLw==", null, false, "", false, "user8@abv.bg" },
                    { "975a5989-f6dc-47b7-b98e-3c499e61cecc", 0, "af3aba59-b012-40ad-b773-72ff8b401192", "user7@abv.bg", false, null, null, false, null, "user7@abv.bg", "user7@abv.bg", "AQAAAAEAACcQAAAAEENywlP5sekkChh/ojmud8ByNYM62I7D3zrPMN0cPsgtzQZ7oUayZoAG7OycH0SQZg==", null, false, "", false, "user7@abv.bg" },
                    { "6f4cf7be-b150-4489-b6b8-883629ebce60", 0, "39a2a1cc-c17e-44a5-bc57-0dc98308f552", "user6@abv.bg", false, null, null, false, null, "user6@abv.bg", "user6@abv.bg", "AQAAAAEAACcQAAAAELHy+pkONtPMrIeaP4+CehS/dkQEA4LPpqRCIfEaTSJm9TRZCGZYdHGyXOM9jzXZAw==", null, false, "", false, "user6@abv.bg" },
                    { "2c5780fc-a85a-4065-8599-374d02037152", 0, "0d9b717a-3d99-4dcb-b3ae-19dad223f61a", "user5@abv.bg", false, null, null, false, null, "user5@abv.bg", "user5@abv.bg", "AQAAAAEAACcQAAAAEA8k5Z9z5WFSGiiohgsaTRX80CdMvPGpZg3tqESPlEMt3gEUIAg7YWn003yUmxDEsg==", null, false, "", false, "user5@abv.bg" },
                    { "ca5a29f1-0250-4ec5-951a-c73868f27a5c", 0, "4bd8cd7e-18b6-445f-8831-ed49e04c5ddc", "user4@abv.bg", false, null, null, false, null, "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEKZt4bDNmPTp2jSskI3mQ9vO2EiJBKwe4YTqIMBCZVZk7W9/3vW1Jm5/MnMrHRhfgQ==", null, false, "", false, "user4@abv.bg" },
                    { "e5bf428a-4799-48d2-b1f7-75d28c9d755d", 0, "be77bd15-dc1f-45b6-b408-54a9caa21409", "user3@abv.bg", false, null, null, false, null, "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEBw6ZnHVuRbrsJ4LFgFexR1Mb97hpcPkYMmfR7FAF2sA/0nJ2w+ta+x26gUOqTsJwg==", null, false, "", false, "user3@abv.bg" },
                    { "9abf94a8-c957-4db9-86a3-8ff93dfd6294", 0, "77976111-d2d5-4dbb-915f-1347b2db5c9d", "user2@abv.bg", false, null, null, false, null, "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEDTnbjbV8HgZVIdGzqzv+CkbQf6ytxCifCwKXg/MTSOJjhOw5OccUwrB+mtKL5Qkhw==", null, false, "", false, "user2@abv.bg" },
                    { "7a58c93e-aab8-4e9e-8e53-b1470da56b0d", 0, "62cd59f2-2f2d-4141-a01c-d379cfe896e7", "user1@abv.bg", false, null, null, false, null, "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEN+vw0WK3Um0a6igUsyRYNkKSV6O5Hs4plRBmHpkOi+qJAAT5/eIukULddffSJhA4g==", null, false, "", false, "user1@abv.bg" },
                    { "7057529b-c353-41e1-bd28-ec0ae0b12792", 0, "be296364-6aca-4f10-a0c6-2636abaa5bc6", "user0@abv.bg", false, null, null, false, null, "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEPfKCTW0YNXdSnWCIQ5NSbGIGS6vzE38FKU5LB20HSJYs+NkXW8VICYAOLBeZjg1MA==", null, false, "", false, "user0@abv.bg" },
                    { "7a17ff56-7ba8-40f7-ba22-a5f4b6b2afd7", 0, "7be62167-8cf6-4146-95fc-ca85fef0ccab", "admin@abv.bg", false, null, null, false, null, "admin@abv.bg", "admin@abv.bg", "AQAAAAEAACcQAAAAEF/nrODxIt2d8vqRJjqKVMABWA1FfROqneebGfGFDtdY9cqQ05B/JkupLO3OdZe42Q==", null, false, "", false, "admin@abv.bg" },
                    { "ea071a13-9280-47b5-af99-4dd3fcc1c41b", 0, "f932e323-8920-482b-8463-6b544dd579f1", "user9@abv.bg", false, null, null, false, null, "user9@abv.bg", "user9@abv.bg", "AQAAAAEAACcQAAAAEL5eXqsi/w44iCywtX4+lu8uGOYimO0rEqcRm2rE/xN3fztXZColqhpNVYI5aL3xig==", null, false, "", false, "user9@abv.bg" },
                    { "54ef30e3-ae40-4d17-ab4a-5b3f898c485a", 0, "38e58e13-d4a6-4145-9aeb-22ab5b91ecc8", "user98@abv.bg", false, null, null, false, null, "user98@abv.bg", "user98@abv.bg", "AQAAAAEAACcQAAAAEC5j1aQy7OVUd+Ycno23rBsvZ5v4+eSgWVB8iyUpinX/j7kNpF64oWBCloMSU/WnJA==", null, false, "", false, "user98@abv.bg" },
                    { "40d210b0-b10c-4dcb-b578-6f0eadd0bd57", 0, "49de3888-173c-4b1a-9a3e-ce4bd6595f80", "user22@abv.bg", false, null, null, false, null, "user22@abv.bg", "user22@abv.bg", "AQAAAAEAACcQAAAAEJiLj+oY6F0qfaPKL5Q77hWMwMCDmkNz5v5MYFLvA16opbis+OR3V8KEBC0PQoIKiw==", null, false, "", false, "user22@abv.bg" },
                    { "346f4e7c-e434-4844-81af-4aa0dfe62a4c", 0, "2e90744e-2f22-4f04-a832-c4ace589eaa6", "user24@abv.bg", false, null, null, false, null, "user24@abv.bg", "user24@abv.bg", "AQAAAAEAACcQAAAAENc8Zzj5WPUzUn0bOIlEAr1XybG5GH8u9jBxHdSjgUiQGSGR618dT84C9p7ERNR2kw==", null, false, "", false, "user24@abv.bg" },
                    { "65bd355c-f31d-474f-923b-2f25e31eddcb", 0, "6f0853c3-2a1d-4e0e-9f6b-bde5b8360615", "user46@abv.bg", false, null, null, false, null, "user46@abv.bg", "user46@abv.bg", "AQAAAAEAACcQAAAAEAZiK1lW405qp58l2K4dVMrlHAMv7f7emKIJ9nHd1CDeCWs/1Uhv/1vwRXIz323gog==", null, false, "", false, "user46@abv.bg" },
                    { "858b5fb3-53e8-4886-8cae-833ae9c014f5", 0, "c169b49f-2d78-497e-bd25-b4522b001f89", "user45@abv.bg", false, null, null, false, null, "user45@abv.bg", "user45@abv.bg", "AQAAAAEAACcQAAAAENhJENelwUVTVacwxo1GfUUnwk3SdM7+6UJq39xUhT3CGuVu/olxeDBRIYx2QIxazw==", null, false, "", false, "user45@abv.bg" },
                    { "272fd4e0-5a10-48c9-890b-ee0ceec764fb", 0, "d245d1da-1cd2-4ca0-ac9c-a86c7601cb8d", "user44@abv.bg", false, null, null, false, null, "user44@abv.bg", "user44@abv.bg", "AQAAAAEAACcQAAAAEDkdcEXzHE26uPwvxoBdngXQK4ODShnvFRI1BRYpHNZ7JTsrbp9OnMhhSgKFTR3PWA==", null, false, "", false, "user44@abv.bg" },
                    { "1997dd42-6a51-4975-aa06-60b5ea54d406", 0, "4e4ebb17-4fe0-421a-b706-db2287879a68", "user43@abv.bg", false, null, null, false, null, "user43@abv.bg", "user43@abv.bg", "AQAAAAEAACcQAAAAEF0KmSqXZf48/vdIXGO3+VKro+z45tY7JYNfMoDjgpVyGZnboPzflLoTf31a+6LW2Q==", null, false, "", false, "user43@abv.bg" },
                    { "49dbed3b-ed40-4fc5-8fc2-fbaf184bf537", 0, "f26dcf74-826c-46fb-b7bf-b22c0131bc11", "user42@abv.bg", false, null, null, false, null, "user42@abv.bg", "user42@abv.bg", "AQAAAAEAACcQAAAAEKTqugBRXwH1y83ZY76WkKX9y8TCyWIfDCmPslKr74p7cerbKtBZZ8iFXUGQN1W3nQ==", null, false, "", false, "user42@abv.bg" },
                    { "e87fc86d-598e-475d-bad7-c938ae87853e", 0, "0b21d9f9-ce49-4e2d-9323-5c2649ba8d52", "user41@abv.bg", false, null, null, false, null, "user41@abv.bg", "user41@abv.bg", "AQAAAAEAACcQAAAAEJBDSHFEs/BJFZrQV50eLC9zh8qCGSwppPher93LgeI9nd8UTJ1bq/ryUnyoIOPsCQ==", null, false, "", false, "user41@abv.bg" },
                    { "4a59e354-0ece-4067-a231-b008fd05c32b", 0, "42c0d9c6-0db8-4cb0-b490-ef74c73f8f72", "user40@abv.bg", false, null, null, false, null, "user40@abv.bg", "user40@abv.bg", "AQAAAAEAACcQAAAAEEsUtvOX2z/+07QFQYOiVGrZdcy50zCqTbnaaje94wMce+tlXJrwwAyDy57PQMJAfA==", null, false, "", false, "user40@abv.bg" },
                    { "147a10cb-6b89-42bd-adf9-2856998ebe6d", 0, "68e88d51-3f95-43c4-88a0-84602f518558", "user39@abv.bg", false, null, null, false, null, "user39@abv.bg", "user39@abv.bg", "AQAAAAEAACcQAAAAEMbHnkSNDY4I4i4SM3qsYoUX1P2jn7A8zHshG4z5kUwadcjfcN+5g+M5HjEw8Rga7A==", null, false, "", false, "user39@abv.bg" },
                    { "c52376d0-194a-4a0a-99fe-108a9ee1691d", 0, "fa6bd2b1-8ec4-45aa-98ca-9c2af633eaae", "user38@abv.bg", false, null, null, false, null, "user38@abv.bg", "user38@abv.bg", "AQAAAAEAACcQAAAAEGQrWa2xdoFiHkrIeqwW56aTLjXPMNvXZ7UC7aMFCWPnrYZ1YyhdamdrU1ZGs3A0vQ==", null, false, "", false, "user38@abv.bg" },
                    { "5edddc36-0bed-48f4-b4f6-bb602054a2a7", 0, "4c8f43a1-9363-4414-86fc-25f0612977bf", "user37@abv.bg", false, null, null, false, null, "user37@abv.bg", "user37@abv.bg", "AQAAAAEAACcQAAAAEGExcAG02d4VQ8WD41rG+VY3xfggWwXbkKQw8vjNU1PbUuwSItBUl8KbqLNYKvxGVw==", null, false, "", false, "user37@abv.bg" },
                    { "1674b06d-2300-4960-8182-7ae10116452c", 0, "1e7a13a8-b741-4b06-8fa9-1bbd00d850c5", "user23@abv.bg", false, null, null, false, null, "user23@abv.bg", "user23@abv.bg", "AQAAAAEAACcQAAAAEOO2bHWlOK1c/1eIRD3Tn7JydT7sEC8UEn23cGYvX/6E25kzWuAUklCoJM9os8ZsYw==", null, false, "", false, "user23@abv.bg" },
                    { "308e3682-0c7a-42e6-a627-ed2d41d94882", 0, "04609b97-e8d4-4d87-a0d4-49fed98521ff", "user36@abv.bg", false, null, null, false, null, "user36@abv.bg", "user36@abv.bg", "AQAAAAEAACcQAAAAEHuXgLSF0az/wP3kVWuc4cv1ZyNxlEJRpy+pKXrcXKjwj64BkvM2JhHMbjR1U9rL5w==", null, false, "", false, "user36@abv.bg" },
                    { "681ee66d-b78c-4512-b445-74d987df76e5", 0, "344626d5-34e7-495b-a45b-1aa11b46cbec", "user34@abv.bg", false, null, null, false, null, "user34@abv.bg", "user34@abv.bg", "AQAAAAEAACcQAAAAECkZ83kCWPMcDKL6FY33jHZ5IOy9NwqLcsTcHRVCa0u3DINkmuzNNjNCPRu7DamY7Q==", null, false, "", false, "user34@abv.bg" },
                    { "48ba41d2-7223-4f97-a851-1e49073dd2d8", 0, "d2a45084-9433-4291-a3b6-e8b9109337df", "user33@abv.bg", false, null, null, false, null, "user33@abv.bg", "user33@abv.bg", "AQAAAAEAACcQAAAAECav+fcxgy7OJN+bXgIFxDdFIuM0rptDhYRAo2cxlhOW2Q96kuJ2m0fp/MMe3Co/Gw==", null, false, "", false, "user33@abv.bg" },
                    { "e09fabdf-414b-43e9-a753-f51f615d0dea", 0, "8d82f047-af72-40ee-beb2-912244ee948d", "user32@abv.bg", false, null, null, false, null, "user32@abv.bg", "user32@abv.bg", "AQAAAAEAACcQAAAAEE6NXfO4A8HVV/36B1DYfaIgshaoFii1/JdH15+MhWnuskKHu7X9g55b8MDnCQIpvQ==", null, false, "", false, "user32@abv.bg" },
                    { "162a81a8-7d3c-4b5f-b8cc-56fb238ffa57", 0, "4738ecf4-59bf-44c4-98e9-0d40473cb0c5", "user31@abv.bg", false, null, null, false, null, "user31@abv.bg", "user31@abv.bg", "AQAAAAEAACcQAAAAEGDEOqLPwMUl2DUAN//0dxtny/QW1bSsIAOI1+FZLGWfD13CXD/T/hX8UxsR2LNHpg==", null, false, "", false, "user31@abv.bg" },
                    { "1af46ce4-6096-4792-bf28-be0b2f23d2df", 0, "fb5f4df2-ba21-48a1-a0df-76e4d3a6413f", "user30@abv.bg", false, null, null, false, null, "user30@abv.bg", "user30@abv.bg", "AQAAAAEAACcQAAAAEEfaZIdsj+9T52URLlQ9xbtQ9hkDSsGLu/Y+pLGi5fdopWaiYG9oED59RpNHnpNbEw==", null, false, "", false, "user30@abv.bg" },
                    { "91ef5b48-6400-43a9-8266-dc34c35576f9", 0, "423a05a6-b4bb-4681-aae5-d6c3bfa03d34", "user29@abv.bg", false, null, null, false, null, "user29@abv.bg", "user29@abv.bg", "AQAAAAEAACcQAAAAEIgEI8B5Sa85HQmk186mq0pe4CXLIvJjGOG4MfrrYTH1cCKLQGmW3IuvQKvspbHSCw==", null, false, "", false, "user29@abv.bg" },
                    { "4d8de18c-a024-4a7d-a559-ac68efcdadf8", 0, "50083e7c-abc7-44e2-aba8-366885aafb3e", "user28@abv.bg", false, null, null, false, null, "user28@abv.bg", "user28@abv.bg", "AQAAAAEAACcQAAAAEF5UwQhoRkWVkCS7H/ZGyMGUZepLByq66BUBYFEjmRgnWe7tFJLET5qQXmjjM92Zng==", null, false, "", false, "user28@abv.bg" },
                    { "192ad026-a7d4-4901-844c-773fda8fdf4f", 0, "d46a3597-bfaa-4d63-8e91-4abc39ecd5d5", "user27@abv.bg", false, null, null, false, null, "user27@abv.bg", "user27@abv.bg", "AQAAAAEAACcQAAAAEIZSOm8T92n1AusJ+X1xD5ZSCLQkrERrE4ezGn30pfI6f5AcLbsbDl5aV0LN8NWq0w==", null, false, "", false, "user27@abv.bg" },
                    { "e496ad21-c3a4-44f5-b187-b0dc4546b79e", 0, "3ad2d650-714d-46bc-bbdc-9f71fe2eaf21", "user26@abv.bg", false, null, null, false, null, "user26@abv.bg", "user26@abv.bg", "AQAAAAEAACcQAAAAEK5XL9pMYs0MAQV2Iy1NdkNUqyuke+fabk8n1lva1mFO7c3iQoSosd1RteBfB/dTuA==", null, false, "", false, "user26@abv.bg" },
                    { "cddb8079-3508-459f-8ff9-593c7bcfbfe8", 0, "af9ec16d-eb7f-4422-b4b0-c5e04c410afc", "user25@abv.bg", false, null, null, false, null, "user25@abv.bg", "user25@abv.bg", "AQAAAAEAACcQAAAAEOQqQn8i2d/UHkkuCjCp0WQ/sTcBBOuFIowbIKlBCxamtfZKftj8/quvRpY0htqaMw==", null, false, "", false, "user25@abv.bg" },
                    { "1115daed-fe00-4fb6-8d50-e9742c64011e", 0, "8d2d126e-8a20-4d3c-b3a8-8b518663bca8", "user35@abv.bg", false, null, null, false, null, "user35@abv.bg", "user35@abv.bg", "AQAAAAEAACcQAAAAEOgRwFRc98NwBuUaWRv7xASZX62A2biN/pw40UtZVzUR42kPZ3O79fjIX+FZpeHlJg==", null, false, "", false, "user35@abv.bg" },
                    { "b498ad1d-6374-48ac-a602-f5dc8e575dbc", 0, "6078c273-7d9e-4122-ae89-9666d68f375f", "user99@abv.bg", false, null, null, false, null, "user99@abv.bg", "user99@abv.bg", "AQAAAAEAACcQAAAAENe+V5JpYLuLLe8NZX79L+nOOsYetvICnIw2wvvkKn1yVAYVwv3Rij0JzsfgcFGkzQ==", null, false, "", false, "user99@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "7a17ff56-7ba8-40f7-ba22-a5f4b6b2afd7", "a2654527-827f-491e-94c9-7ddb8d316281" },
                    { "05de56c2-1744-4b45-bcf0-4c26f89115ca", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "85dd1248-73f2-425d-b72f-8c5cd6f34432", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "22d67832-b157-4a91-b9ac-a1bc3abce5cb", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ee7212a1-0122-467b-bc52-74b82a3f1910", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "28c82f51-a307-4a39-abd7-9c7e948043c6", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "bf0eeacd-8397-4faa-b022-67422f37f364", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "0d556737-881d-4eef-aa4f-4b9e9c1ed59b", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "36770434-1c4e-4035-a67b-47f872d1e8bc", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "bd95ef3d-f544-4f5c-b635-ee756447a4d8", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ea841e97-898a-48ff-a2d7-599001f6fd10", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "e78fd5a0-87cb-40c8-a2ce-4331257a4301", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "8b525c36-b532-4cf0-a0d5-22d2e2dfd2d3", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "32d01b93-b9c2-422c-a870-81b13e8364c7", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "bf7d4ae5-8905-40ce-9f7e-e2389ddfe488", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "74c185b9-8aae-4d6c-9089-e053b8ed82e4", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "0faa63da-ae8c-4252-96ce-e60731d31f02", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "caa2d573-9668-4c4e-b09e-461bd8e1ee1e", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "25429f64-a636-4520-8b67-504ef23cd340", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "b31084f4-f95b-4dd8-ab1f-d19bd495ea2e", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "7d8c163c-a400-45af-b8b7-c0ce5eb82d70", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "73839d78-1861-4bde-a9a5-7462ae96e399", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "09322e5c-3d58-46db-ba0a-36bb26edc761", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "581973d4-edff-4027-86fb-222c03dd5b68", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "6944b8ed-d73f-4819-86f9-05e1bb824345", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "22423ba0-822a-40a5-bda0-21c7c0a83425", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "5dcc31a0-0824-4b0e-a011-722c1714968f", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "c05b1471-e855-4b79-bb33-b5bff6abf3ce", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "82ed05a1-67c0-4b6d-85de-7c1b73407668", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "c601aa9b-1c90-4321-9ed8-a3d7985565a5", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "7192d4e3-6406-44c4-88bd-0c358e46cc0c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "acb3b004-139f-410d-a48e-310c81ab1756", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "28fc329c-d8eb-46a3-b092-e5e2dbc7c8e5", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "0149f011-c289-4322-b1ea-7c7366c40c20", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "bafd8676-1ee8-405d-86b0-8626fdc662f2", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "61e642f4-06b0-4e51-ba69-462f336dd4bb", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1f282963-5156-4a78-9afe-ec3d409f4790", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "420abf51-4ef7-4845-b592-3ff9ae4f74a2", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "3d6273d3-8efa-4c35-946c-3ea58d9efc82", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "10ddc1be-8f84-4624-8f24-a8056a90679d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "d25d1348-0d2b-46a1-a977-41cd825394e7", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "3fb0d047-892d-4892-9454-bcd0b758357f", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ad8b207f-1383-4e1b-aebf-d2a3e89a3830", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "93688c5b-3bb3-4dc0-a651-66601a946992", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "5b5cb67a-42d1-4480-ac87-805658611cbd", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "411dad10-7f41-4f04-a7e4-bbc08ad9fe12", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "6afdfe59-29a8-4bec-9399-2c37a2edba2a", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "a9049e95-b8a7-4937-b0a2-b50f04c11d31", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "c1db2409-bcd4-4ba4-9637-86bf9919a28c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "54ef30e3-ae40-4d17-ab4a-5b3f898c485a", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "59331a1a-1293-45b9-98f1-245ec064fff0", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "bd6e4d5d-cb3a-431a-b9a6-a9dd8e8d72e2", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "b64ac5a5-d9c7-4232-974c-45811065c097", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "b2945152-d6f1-4fef-ae01-cb976725c8c6", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "a53e5a13-f58c-42de-8731-9bc1ce77fc5d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ccda49ab-4b4c-4b7c-a2ac-082d945578b4", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1d82720c-8956-437b-973a-aa8cb0f9f730", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "d666a286-7ac1-49ac-bcb7-ef19f32e5f99", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "04d3b90d-7fd1-4ed1-8174-26614a01285c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "50a53241-c66b-4e3a-a535-755d4373f54d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "668002db-c12f-4611-bc59-87cc8011ca68", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "d31fd758-dc6a-4a19-aa2d-d2ef339b0120", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "39d9892b-1744-4934-99e4-fcd5714f21ac", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ea071a13-9280-47b5-af99-4dd3fcc1c41b", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1bc945dc-39b4-46de-a6ef-1922fde3a969", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "975a5989-f6dc-47b7-b98e-3c499e61cecc", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "6f4cf7be-b150-4489-b6b8-883629ebce60", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "2c5780fc-a85a-4065-8599-374d02037152", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "ca5a29f1-0250-4ec5-951a-c73868f27a5c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "e5bf428a-4799-48d2-b1f7-75d28c9d755d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "9abf94a8-c957-4db9-86a3-8ff93dfd6294", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "7a58c93e-aab8-4e9e-8e53-b1470da56b0d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "7057529b-c353-41e1-bd28-ec0ae0b12792", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "6853475f-1125-4aa1-80d3-1db786b769fa", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "40d210b0-b10c-4dcb-b578-6f0eadd0bd57", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1674b06d-2300-4960-8182-7ae10116452c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "346f4e7c-e434-4844-81af-4aa0dfe62a4c", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "65bd355c-f31d-474f-923b-2f25e31eddcb", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "858b5fb3-53e8-4886-8cae-833ae9c014f5", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "272fd4e0-5a10-48c9-890b-ee0ceec764fb", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1997dd42-6a51-4975-aa06-60b5ea54d406", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "49dbed3b-ed40-4fc5-8fc2-fbaf184bf537", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "e87fc86d-598e-475d-bad7-c938ae87853e", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "4a59e354-0ece-4067-a231-b008fd05c32b", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "147a10cb-6b89-42bd-adf9-2856998ebe6d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "c52376d0-194a-4a0a-99fe-108a9ee1691d", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "5edddc36-0bed-48f4-b4f6-bb602054a2a7", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "0991be9d-cb8d-4614-8b1c-ed4e298c8653", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "308e3682-0c7a-42e6-a627-ed2d41d94882", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "681ee66d-b78c-4512-b445-74d987df76e5", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "48ba41d2-7223-4f97-a851-1e49073dd2d8", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "e09fabdf-414b-43e9-a753-f51f615d0dea", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "162a81a8-7d3c-4b5f-b8cc-56fb238ffa57", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1af46ce4-6096-4792-bf28-be0b2f23d2df", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "91ef5b48-6400-43a9-8266-dc34c35576f9", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "4d8de18c-a024-4a7d-a559-ac68efcdadf8", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "192ad026-a7d4-4901-844c-773fda8fdf4f", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "e496ad21-c3a4-44f5-b187-b0dc4546b79e", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "cddb8079-3508-459f-8ff9-593c7bcfbfe8", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "1115daed-fe00-4fb6-8d50-e9742c64011e", "491dc564-0462-475f-8c53-3e03f84d3fdf" },
                    { "b498ad1d-6374-48ac-a602-f5dc8e575dbc", "491dc564-0462-475f-8c53-3e03f84d3fdf" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EventId",
                table: "Orders",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0149f011-c289-4322-b1ea-7c7366c40c20", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04d3b90d-7fd1-4ed1-8174-26614a01285c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "05de56c2-1744-4b45-bcf0-4c26f89115ca", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "09322e5c-3d58-46db-ba0a-36bb26edc761", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0991be9d-cb8d-4614-8b1c-ed4e298c8653", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0d556737-881d-4eef-aa4f-4b9e9c1ed59b", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0faa63da-ae8c-4252-96ce-e60731d31f02", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "10ddc1be-8f84-4624-8f24-a8056a90679d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1115daed-fe00-4fb6-8d50-e9742c64011e", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "147a10cb-6b89-42bd-adf9-2856998ebe6d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "162a81a8-7d3c-4b5f-b8cc-56fb238ffa57", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1674b06d-2300-4960-8182-7ae10116452c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "192ad026-a7d4-4901-844c-773fda8fdf4f", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1997dd42-6a51-4975-aa06-60b5ea54d406", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1af46ce4-6096-4792-bf28-be0b2f23d2df", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1bc945dc-39b4-46de-a6ef-1922fde3a969", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1d82720c-8956-437b-973a-aa8cb0f9f730", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1f282963-5156-4a78-9afe-ec3d409f4790", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22423ba0-822a-40a5-bda0-21c7c0a83425", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22d67832-b157-4a91-b9ac-a1bc3abce5cb", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "25429f64-a636-4520-8b67-504ef23cd340", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "272fd4e0-5a10-48c9-890b-ee0ceec764fb", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "28c82f51-a307-4a39-abd7-9c7e948043c6", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "28fc329c-d8eb-46a3-b092-e5e2dbc7c8e5", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2c5780fc-a85a-4065-8599-374d02037152", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "308e3682-0c7a-42e6-a627-ed2d41d94882", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "32d01b93-b9c2-422c-a870-81b13e8364c7", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "346f4e7c-e434-4844-81af-4aa0dfe62a4c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "36770434-1c4e-4035-a67b-47f872d1e8bc", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "39d9892b-1744-4934-99e4-fcd5714f21ac", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3d6273d3-8efa-4c35-946c-3ea58d9efc82", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3fb0d047-892d-4892-9454-bcd0b758357f", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "40d210b0-b10c-4dcb-b578-6f0eadd0bd57", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "411dad10-7f41-4f04-a7e4-bbc08ad9fe12", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "420abf51-4ef7-4845-b592-3ff9ae4f74a2", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48ba41d2-7223-4f97-a851-1e49073dd2d8", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "49dbed3b-ed40-4fc5-8fc2-fbaf184bf537", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4a59e354-0ece-4067-a231-b008fd05c32b", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d8de18c-a024-4a7d-a559-ac68efcdadf8", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "50a53241-c66b-4e3a-a535-755d4373f54d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "54ef30e3-ae40-4d17-ab4a-5b3f898c485a", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "581973d4-edff-4027-86fb-222c03dd5b68", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "59331a1a-1293-45b9-98f1-245ec064fff0", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b5cb67a-42d1-4480-ac87-805658611cbd", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5dcc31a0-0824-4b0e-a011-722c1714968f", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5edddc36-0bed-48f4-b4f6-bb602054a2a7", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "61e642f4-06b0-4e51-ba69-462f336dd4bb", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "65bd355c-f31d-474f-923b-2f25e31eddcb", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "668002db-c12f-4611-bc59-87cc8011ca68", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "681ee66d-b78c-4512-b445-74d987df76e5", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6853475f-1125-4aa1-80d3-1db786b769fa", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6944b8ed-d73f-4819-86f9-05e1bb824345", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6afdfe59-29a8-4bec-9399-2c37a2edba2a", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6f4cf7be-b150-4489-b6b8-883629ebce60", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7057529b-c353-41e1-bd28-ec0ae0b12792", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7192d4e3-6406-44c4-88bd-0c358e46cc0c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "73839d78-1861-4bde-a9a5-7462ae96e399", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "74c185b9-8aae-4d6c-9089-e053b8ed82e4", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7a17ff56-7ba8-40f7-ba22-a5f4b6b2afd7", "a2654527-827f-491e-94c9-7ddb8d316281" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7a58c93e-aab8-4e9e-8e53-b1470da56b0d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7d8c163c-a400-45af-b8b7-c0ce5eb82d70", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82ed05a1-67c0-4b6d-85de-7c1b73407668", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "858b5fb3-53e8-4886-8cae-833ae9c014f5", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "85dd1248-73f2-425d-b72f-8c5cd6f34432", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8b525c36-b532-4cf0-a0d5-22d2e2dfd2d3", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "91ef5b48-6400-43a9-8266-dc34c35576f9", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "93688c5b-3bb3-4dc0-a651-66601a946992", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "975a5989-f6dc-47b7-b98e-3c499e61cecc", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9abf94a8-c957-4db9-86a3-8ff93dfd6294", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a53e5a13-f58c-42de-8731-9bc1ce77fc5d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a9049e95-b8a7-4937-b0a2-b50f04c11d31", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "acb3b004-139f-410d-a48e-310c81ab1756", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ad8b207f-1383-4e1b-aebf-d2a3e89a3830", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2945152-d6f1-4fef-ae01-cb976725c8c6", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b31084f4-f95b-4dd8-ab1f-d19bd495ea2e", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b498ad1d-6374-48ac-a602-f5dc8e575dbc", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b64ac5a5-d9c7-4232-974c-45811065c097", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bafd8676-1ee8-405d-86b0-8626fdc662f2", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bd6e4d5d-cb3a-431a-b9a6-a9dd8e8d72e2", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bd95ef3d-f544-4f5c-b635-ee756447a4d8", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf0eeacd-8397-4faa-b022-67422f37f364", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf7d4ae5-8905-40ce-9f7e-e2389ddfe488", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c05b1471-e855-4b79-bb33-b5bff6abf3ce", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c1db2409-bcd4-4ba4-9637-86bf9919a28c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c52376d0-194a-4a0a-99fe-108a9ee1691d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c601aa9b-1c90-4321-9ed8-a3d7985565a5", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ca5a29f1-0250-4ec5-951a-c73868f27a5c", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "caa2d573-9668-4c4e-b09e-461bd8e1ee1e", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ccda49ab-4b4c-4b7c-a2ac-082d945578b4", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cddb8079-3508-459f-8ff9-593c7bcfbfe8", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d25d1348-0d2b-46a1-a977-41cd825394e7", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d31fd758-dc6a-4a19-aa2d-d2ef339b0120", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d666a286-7ac1-49ac-bcb7-ef19f32e5f99", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e09fabdf-414b-43e9-a753-f51f615d0dea", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e496ad21-c3a4-44f5-b187-b0dc4546b79e", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e5bf428a-4799-48d2-b1f7-75d28c9d755d", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e78fd5a0-87cb-40c8-a2ce-4331257a4301", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e87fc86d-598e-475d-bad7-c938ae87853e", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ea071a13-9280-47b5-af99-4dd3fcc1c41b", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ea841e97-898a-48ff-a2d7-599001f6fd10", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ee7212a1-0122-467b-bc52-74b82a3f1910", "491dc564-0462-475f-8c53-3e03f84d3fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "491dc564-0462-475f-8c53-3e03f84d3fdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2654527-827f-491e-94c9-7ddb8d316281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0149f011-c289-4322-b1ea-7c7366c40c20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04d3b90d-7fd1-4ed1-8174-26614a01285c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05de56c2-1744-4b45-bcf0-4c26f89115ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09322e5c-3d58-46db-ba0a-36bb26edc761");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0991be9d-cb8d-4614-8b1c-ed4e298c8653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d556737-881d-4eef-aa4f-4b9e9c1ed59b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0faa63da-ae8c-4252-96ce-e60731d31f02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ddc1be-8f84-4624-8f24-a8056a90679d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1115daed-fe00-4fb6-8d50-e9742c64011e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "147a10cb-6b89-42bd-adf9-2856998ebe6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162a81a8-7d3c-4b5f-b8cc-56fb238ffa57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1674b06d-2300-4960-8182-7ae10116452c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "192ad026-a7d4-4901-844c-773fda8fdf4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1997dd42-6a51-4975-aa06-60b5ea54d406");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1af46ce4-6096-4792-bf28-be0b2f23d2df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bc945dc-39b4-46de-a6ef-1922fde3a969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d82720c-8956-437b-973a-aa8cb0f9f730");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f282963-5156-4a78-9afe-ec3d409f4790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22423ba0-822a-40a5-bda0-21c7c0a83425");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d67832-b157-4a91-b9ac-a1bc3abce5cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25429f64-a636-4520-8b67-504ef23cd340");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "272fd4e0-5a10-48c9-890b-ee0ceec764fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28c82f51-a307-4a39-abd7-9c7e948043c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28fc329c-d8eb-46a3-b092-e5e2dbc7c8e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5780fc-a85a-4065-8599-374d02037152");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308e3682-0c7a-42e6-a627-ed2d41d94882");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32d01b93-b9c2-422c-a870-81b13e8364c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "346f4e7c-e434-4844-81af-4aa0dfe62a4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36770434-1c4e-4035-a67b-47f872d1e8bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39d9892b-1744-4934-99e4-fcd5714f21ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d6273d3-8efa-4c35-946c-3ea58d9efc82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fb0d047-892d-4892-9454-bcd0b758357f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40d210b0-b10c-4dcb-b578-6f0eadd0bd57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "411dad10-7f41-4f04-a7e4-bbc08ad9fe12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420abf51-4ef7-4845-b592-3ff9ae4f74a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ba41d2-7223-4f97-a851-1e49073dd2d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dbed3b-ed40-4fc5-8fc2-fbaf184bf537");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a59e354-0ece-4067-a231-b008fd05c32b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d8de18c-a024-4a7d-a559-ac68efcdadf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50a53241-c66b-4e3a-a535-755d4373f54d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54ef30e3-ae40-4d17-ab4a-5b3f898c485a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "581973d4-edff-4027-86fb-222c03dd5b68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59331a1a-1293-45b9-98f1-245ec064fff0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b5cb67a-42d1-4480-ac87-805658611cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dcc31a0-0824-4b0e-a011-722c1714968f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5edddc36-0bed-48f4-b4f6-bb602054a2a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61e642f4-06b0-4e51-ba69-462f336dd4bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65bd355c-f31d-474f-923b-2f25e31eddcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "668002db-c12f-4611-bc59-87cc8011ca68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "681ee66d-b78c-4512-b445-74d987df76e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6853475f-1125-4aa1-80d3-1db786b769fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6944b8ed-d73f-4819-86f9-05e1bb824345");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6afdfe59-29a8-4bec-9399-2c37a2edba2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f4cf7be-b150-4489-b6b8-883629ebce60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7057529b-c353-41e1-bd28-ec0ae0b12792");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7192d4e3-6406-44c4-88bd-0c358e46cc0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73839d78-1861-4bde-a9a5-7462ae96e399");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74c185b9-8aae-4d6c-9089-e053b8ed82e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a17ff56-7ba8-40f7-ba22-a5f4b6b2afd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a58c93e-aab8-4e9e-8e53-b1470da56b0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d8c163c-a400-45af-b8b7-c0ce5eb82d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ed05a1-67c0-4b6d-85de-7c1b73407668");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "858b5fb3-53e8-4886-8cae-833ae9c014f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85dd1248-73f2-425d-b72f-8c5cd6f34432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b525c36-b532-4cf0-a0d5-22d2e2dfd2d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91ef5b48-6400-43a9-8266-dc34c35576f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93688c5b-3bb3-4dc0-a651-66601a946992");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "975a5989-f6dc-47b7-b98e-3c499e61cecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9abf94a8-c957-4db9-86a3-8ff93dfd6294");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a53e5a13-f58c-42de-8731-9bc1ce77fc5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9049e95-b8a7-4937-b0a2-b50f04c11d31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb3b004-139f-410d-a48e-310c81ab1756");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad8b207f-1383-4e1b-aebf-d2a3e89a3830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2945152-d6f1-4fef-ae01-cb976725c8c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b31084f4-f95b-4dd8-ab1f-d19bd495ea2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b498ad1d-6374-48ac-a602-f5dc8e575dbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b64ac5a5-d9c7-4232-974c-45811065c097");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bafd8676-1ee8-405d-86b0-8626fdc662f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd6e4d5d-cb3a-431a-b9a6-a9dd8e8d72e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd95ef3d-f544-4f5c-b635-ee756447a4d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf0eeacd-8397-4faa-b022-67422f37f364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7d4ae5-8905-40ce-9f7e-e2389ddfe488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05b1471-e855-4b79-bb33-b5bff6abf3ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1db2409-bcd4-4ba4-9637-86bf9919a28c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c52376d0-194a-4a0a-99fe-108a9ee1691d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c601aa9b-1c90-4321-9ed8-a3d7985565a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca5a29f1-0250-4ec5-951a-c73868f27a5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caa2d573-9668-4c4e-b09e-461bd8e1ee1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccda49ab-4b4c-4b7c-a2ac-082d945578b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cddb8079-3508-459f-8ff9-593c7bcfbfe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d25d1348-0d2b-46a1-a977-41cd825394e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d31fd758-dc6a-4a19-aa2d-d2ef339b0120");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d666a286-7ac1-49ac-bcb7-ef19f32e5f99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e09fabdf-414b-43e9-a753-f51f615d0dea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e496ad21-c3a4-44f5-b187-b0dc4546b79e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5bf428a-4799-48d2-b1f7-75d28c9d755d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e78fd5a0-87cb-40c8-a2ce-4331257a4301");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87fc86d-598e-475d-bad7-c938ae87853e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea071a13-9280-47b5-af99-4dd3fcc1c41b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea841e97-898a-48ff-a2d7-599001f6fd10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee7212a1-0122-467b-bc52-74b82a3f1910");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
