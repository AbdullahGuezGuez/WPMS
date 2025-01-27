﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190528134216_azureCommit")]
    partial class azureCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Archived");

                    b.Property<int>("CreatorId");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int?>("NextStepId");

                    b.Property<int>("OrganizationId");

                    b.Property<string>("Title");

                    b.Property<bool>("TodoChecked");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Backend.Models.ActivityContactperson", b =>
                {
                    b.Property<int>("ActivityId");

                    b.Property<int>("ContactpersonId");

                    b.HasKey("ActivityId", "ContactpersonId");

                    b.HasIndex("ContactpersonId");

                    b.ToTable("ActivityContactpersons");
                });

            modelBuilder.Entity("Backend.Models.ActivityUser", b =>
                {
                    b.Property<int>("ActivityId");

                    b.Property<int>("UserId");

                    b.HasKey("ActivityId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ActivityUsers");
                });

            modelBuilder.Entity("Backend.Models.Contactperson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Initials");

                    b.Property<string>("Mail");

                    b.Property<bool>("Masked");

                    b.Property<string>("Name");

                    b.Property<bool>("Responsible");

                    b.Property<string>("Role");

                    b.Property<string>("SecTelephone");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contactpersons");
                });

            modelBuilder.Entity("Backend.Models.CustomField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Data");

                    b.Property<int?>("ProjectId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProjectId");

                    b.ToTable("CustomFields");
                });

            modelBuilder.Entity("Backend.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Attitude");

                    b.Property<string>("CustomerDescription");

                    b.Property<string>("CustomerStatus")
                        .IsRequired();

                    b.Property<string>("Customermail");

                    b.Property<DateTime>("FirstContacted");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizationId");

                    b.Property<string>("OrganizationNumber");

                    b.Property<string>("Region");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Backend.Models.DbClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.HasKey("Id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("Backend.Models.Membership", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IdMember");

                    b.Property<int>("MemberType");

                    b.Property<string>("TrelloBoardId");

                    b.HasKey("Id");

                    b.HasIndex("TrelloBoardId");

                    b.ToTable("Membership");
                });

            modelBuilder.Entity("Backend.Models.NextStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId");

                    b.Property<int?>("CreatorId");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("NextStep");
                });

            modelBuilder.Entity("Backend.Models.NextstepContactperson", b =>
                {
                    b.Property<int>("NextstepId");

                    b.Property<int>("ContactpersonId");

                    b.HasKey("NextstepId", "ContactpersonId");

                    b.HasIndex("ContactpersonId");

                    b.ToTable("NextstepContactpersons");
                });

            modelBuilder.Entity("Backend.Models.NextstepUser", b =>
                {
                    b.Property<int>("NextstepId");

                    b.Property<int>("UserId");

                    b.HasKey("NextstepId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("NextstepUsers");
                });

            modelBuilder.Entity("Backend.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("TrelloTeamName");

                    b.Property<string>("Trellokey");

                    b.Property<string>("Trellotoken");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Backend.Models.OrganizationUser", b =>
                {
                    b.Property<int>("OrganizationId");

                    b.Property<int>("UserId");

                    b.HasKey("OrganizationId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("OrganizationUser");
                });

            modelBuilder.Entity("Backend.Models.PMS.UserCards", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("TrelloCardId");

                    b.Property<string>("TrelloMemberId");

                    b.HasKey("UserId", "TrelloCardId");

                    b.HasIndex("TrelloCardId");

                    b.ToTable("UserCards");
                });

            modelBuilder.Entity("Backend.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("CreatorId");

                    b.Property<string>("CriticalDescription");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("EstimatedTime");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizationId");

                    b.Property<int>("Priority");

                    b.Property<int?>("Progress");

                    b.Property<int?>("ResponsibleContactpersonId");

                    b.Property<int?>("ResponsibleUserId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Toggl");

                    b.Property<int?>("TotalBudget");

                    b.Property<string>("TrelloBoardId");

                    b.Property<int>("UsedTime");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Backend.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("Backend.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<int?>("OrganizationId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.HasIndex("OrganizationId");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Backend.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.Property<int?>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("TicketId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Backend.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccomplishedTime");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FinishedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Priority");

                    b.Property<string>("Responsible");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Status");

                    b.Property<string>("TimeEstimate");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Backend.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeId");

                    b.Property<bool>("Confirmed");

                    b.Property<DateTime>("ConfirmedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Duedate");

                    b.Property<DateTime>("Issued");

                    b.Property<string>("IssuedBy");

                    b.Property<int>("OrganizationId");

                    b.Property<string>("ProblemSeverity")
                        .IsRequired();

                    b.Property<int?>("ProjectId");

                    b.Property<string>("SolveDescription");

                    b.Property<bool>("Solved");

                    b.Property<DateTime>("SolvedDate");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Backend.Models.TicketComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachments");

                    b.Property<string>("Creator");

                    b.Property<string>("Message");

                    b.Property<int?>("TicketId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketComments");
                });

            modelBuilder.Entity("Backend.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Done");

                    b.Property<DateTime>("Duedate");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<int>("UserCreator");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("Backend.Models.TrelloBoard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Closed");

                    b.Property<DateTime>("DateLastView");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizationId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("TrelloBoards");
                });

            modelBuilder.Entity("Backend.Models.TrelloList", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Closed");

                    b.Property<string>("IdBoard");

                    b.Property<string>("Name");

                    b.Property<float>("Pos");

                    b.HasKey("Id");

                    b.ToTable("TrelloLists");
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<string>("Initials");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<bool>("Masked");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("TrelloMemberId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Backend.Models.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("CustomFieldItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IdCustomField");

                    b.Property<string>("IdModel");

                    b.Property<string>("ModelType");

                    b.Property<string>("TrelloCardId");

                    b.HasKey("Id");

                    b.HasIndex("TrelloCardId");

                    b.ToTable("CustomFieldItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TrelloCard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Closed");

                    b.Property<DateTime>("DateLastActivity");

                    b.Property<string>("Desc");

                    b.Property<string>("IdBoard");

                    b.Property<string>("IdList");

                    b.Property<string>("Name");

                    b.Property<float>("Pos");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("TrelloCards");
                });

            modelBuilder.Entity("Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomFieldItemId");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldItemId")
                        .IsUnique()
                        .HasFilter("[CustomFieldItemId] IS NOT NULL");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("Backend.Models.Activity", b =>
                {
                    b.HasOne("Backend.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Backend.Models.ActivityContactperson", b =>
                {
                    b.HasOne("Backend.Models.Activity", "Activity")
                        .WithMany("ActivityContactpersons")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.Contactperson", "Contactperson")
                        .WithMany("ActivityContactpersons")
                        .HasForeignKey("ContactpersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.ActivityUser", b =>
                {
                    b.HasOne("Backend.Models.Activity", "Activity")
                        .WithMany("ActivityUsers")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("ActivityUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.Contactperson", b =>
                {
                    b.HasOne("Backend.Models.Customer")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.CustomField", b =>
                {
                    b.HasOne("Backend.Models.Customer")
                        .WithMany("CustomFields")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.Project")
                        .WithMany("CustomFields")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Backend.Models.Customer", b =>
                {
                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationCustomer")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.Membership", b =>
                {
                    b.HasOne("Backend.Models.TrelloBoard", "TrelloBoard")
                        .WithMany("Memberships")
                        .HasForeignKey("TrelloBoardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.NextstepContactperson", b =>
                {
                    b.HasOne("Backend.Models.Contactperson", "Contactperson")
                        .WithMany("NextstepContactpersons")
                        .HasForeignKey("ContactpersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.NextStep", "NextStep")
                        .WithMany("NextstepContactpersons")
                        .HasForeignKey("NextstepId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.NextstepUser", b =>
                {
                    b.HasOne("Backend.Models.NextStep", "NextStep")
                        .WithMany("NextstepUsers")
                        .HasForeignKey("NextstepId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("NextstepUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.OrganizationUser", b =>
                {
                    b.HasOne("Backend.Models.Organization", "Organization")
                        .WithMany("OrganizationUsers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("Organizations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.PMS.UserCards", b =>
                {
                    b.HasOne("TrelloCard", "TrelloCard")
                        .WithMany("UserCards")
                        .HasForeignKey("TrelloCardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("UserCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.Project", b =>
                {
                    b.HasOne("Backend.Models.Customer")
                        .WithMany("CustomerProjects")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationProjects")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.ProjectUser", b =>
                {
                    b.HasOne("Backend.Models.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.Role", b =>
                {
                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationRoles")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("Backend.Models.Tag", b =>
                {
                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationTag")
                        .HasForeignKey("OrganizationId");

                    b.HasOne("Backend.Models.Ticket")
                        .WithMany("Tags")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("Backend.Models.Ticket", b =>
                {
                    b.HasOne("Backend.Models.User", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId");

                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationTicket")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.Project")
                        .WithMany("Tickets")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Backend.Models.TicketComment", b =>
                {
                    b.HasOne("Backend.Models.Ticket")
                        .WithMany("TicketComments")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("Backend.Models.TrelloBoard", b =>
                {
                    b.HasOne("Backend.Models.Organization")
                        .WithMany("OrganizationTrelloBoards")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.UserRole", b =>
                {
                    b.HasOne("Backend.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CustomFieldItem", b =>
                {
                    b.HasOne("TrelloCard")
                        .WithMany("CustomFieldItems")
                        .HasForeignKey("TrelloCardId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Backend.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Backend.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Backend.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Backend.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Value", b =>
                {
                    b.HasOne("CustomFieldItem")
                        .WithOne("Value")
                        .HasForeignKey("Value", "CustomFieldItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
