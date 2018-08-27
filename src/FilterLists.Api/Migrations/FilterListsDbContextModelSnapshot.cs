﻿// <auto-generated />

using System;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FilterLists.Api.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    internal class FilterListsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
            {
                b.Property<ushort>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<bool>("CantSnapshot");

                b.Property<string>("ChatUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Description")
                 .HasColumnType("TEXT");

                b.Property<string>("DescriptionSourceUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("DiscontinuedDate")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("DATE")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("DonateUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("EmailAddress")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("ForumUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("IssuesUrl")
                 .HasColumnType("TEXT");

                b.Property<byte>("LicenseId")
                 .ValueGeneratedOnAdd()
                 .HasDefaultValue((byte)5);

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<string>("PolicyUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("PublishedDate")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("DATE")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("SubmissionUrl")
                 .HasColumnType("TEXT");

                b.Property<byte?>("SyntaxId");

                b.Property<string>("ViewUrl")
                 .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("LicenseId");

                b.HasIndex("SyntaxId");

                b.ToTable("filterlists");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListLanguage", b =>
            {
                b.Property<ushort>("FilterListId");

                b.Property<ushort>("LanguageId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "LanguageId");

                b.HasIndex("LanguageId");

                b.ToTable("filterlists_languages");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListMaintainer", b =>
            {
                b.Property<ushort>("FilterListId");

                b.Property<ushort>("MaintainerId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "MaintainerId");

                b.HasIndex("MaintainerId");

                b.ToTable("filterlists_maintainers");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListTag", b =>
            {
                b.Property<ushort>("FilterListId");

                b.Property<byte>("TagId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("FilterListId", "TagId");

                b.HasIndex("TagId");

                b.ToTable("filterlists_tags");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Fork", b =>
            {
                b.Property<ushort>("ForkFilterListId");

                b.Property<ushort>("UpstreamFilterListId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("ForkFilterListId", "UpstreamFilterListId");

                b.HasIndex("UpstreamFilterListId");

                b.ToTable("forks");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Merge", b =>
            {
                b.Property<ushort>("MergeFilterListId");

                b.Property<ushort>("UpstreamFilterListId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("MergeFilterListId", "UpstreamFilterListId");

                b.HasIndex("UpstreamFilterListId");

                b.ToTable("merges");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SnapshotRule", b =>
            {
                b.Property<uint>("SnapshotId");

                b.Property<uint>("RuleId");

                b.HasKey("SnapshotId", "RuleId");

                b.HasIndex("RuleId");

                b.ToTable("snapshots_rules");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SoftwareSyntax", b =>
            {
                b.Property<byte>("SyntaxId");

                b.Property<byte>("SoftwareId");

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.HasKey("SyntaxId", "SoftwareId");

                b.HasIndex("SoftwareId");

                b.ToTable("software_syntaxes");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Language", b =>
            {
                b.Property<ushort>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Iso6391")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(2)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392B")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6392T")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("Iso6393")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(3)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("LocalName")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.HasKey("Id");

                b.ToTable("languages");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.License", b =>
            {
                b.Property<byte>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TINYINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DescriptionUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<bool>("PermissiveAdaptation");

                b.Property<bool>("PermissiveCommercial");

                b.HasKey("Id");

                b.ToTable("licenses");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Maintainer", b =>
            {
                b.Property<ushort>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("EmailAddress")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.Property<string>("TwitterHandle")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("VARCHAR(126)")
                 .HasDefaultValueSql("NULL");

                b.HasKey("Id");

                b.ToTable("maintainers");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Rule", b =>
            {
                b.Property<uint>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("INT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Raw")
                 .IsRequired()
                 .HasColumnType("LONGTEXT");

                b.HasKey("Id");

                b.ToTable("rules");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Snapshot", b =>
            {
                b.Property<uint>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("MEDIUMINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<ushort>("FilterListId");

                b.Property<short?>("HttpStatusCode")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("SMALLINT")
                 .HasDefaultValueSql("NULL");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<bool>("WasSuccessful");

                b.Property<DateTime?>("WaybackTimestamp")
                 .HasColumnType("TIMESTAMP");

                b.HasKey("Id");

                b.HasIndex("FilterListId");

                b.ToTable("snapshots");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Software", b =>
            {
                b.Property<byte>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TINYINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DownloadUrl")
                 .HasColumnType("TEXT");

                b.Property<string>("HomeUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("software");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Syntax", b =>
            {
                b.Property<byte>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TINYINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("DefinitionUrl")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("syntaxes");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Tag", b =>
            {
                b.Property<byte>("Id")
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TINYINT UNSIGNED")
                 .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CreatedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAdd()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp()");

                b.Property<string>("Description")
                 .HasColumnType("TEXT");

                b.Property<DateTime?>("ModifiedDateUtc")
                 .IsRequired()
                 .ValueGeneratedOnAddOrUpdate()
                 .HasColumnType("TIMESTAMP")
                 .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");

                b.Property<string>("Name")
                 .IsRequired()
                 .HasColumnType("VARCHAR(126)");

                b.HasKey("Id");

                b.ToTable("tags");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.FilterList", b =>
            {
                b.HasOne("FilterLists.Data.Entities.License", "License")
                 .WithMany("FilterLists")
                 .HasForeignKey("LicenseId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Syntax", "Syntax")
                 .WithMany("FilterLists")
                 .HasForeignKey("SyntaxId");
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListLanguage", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                 .WithMany("FilterListLanguages")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Language", "Language")
                 .WithMany("FilterListLanguages")
                 .HasForeignKey("LanguageId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListMaintainer", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                 .WithMany("FilterListMaintainers")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Maintainer", "Maintainer")
                 .WithMany("FilterListMaintainers")
                 .HasForeignKey("MaintainerId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.FilterListTag", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                 .WithMany("FilterListTags")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Tag", "Tag")
                 .WithMany("FilterListTags")
                 .HasForeignKey("TagId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Fork", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "ForkFilterList")
                 .WithMany("ForkFilterLists")
                 .HasForeignKey("ForkFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.FilterList", "UpstreamFilterList")
                 .WithMany("UpstreamForkFilterLists")
                 .HasForeignKey("UpstreamFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.Merge", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "MergeFilterList")
                 .WithMany("MergeFilterLists")
                 .HasForeignKey("MergeFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.FilterList", "UpstreamFilterList")
                 .WithMany("UpstreamMergeFilterLists")
                 .HasForeignKey("UpstreamFilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SnapshotRule", b =>
            {
                b.HasOne("FilterLists.Data.Entities.Rule", "Rule")
                 .WithMany("SnapshotRules")
                 .HasForeignKey("RuleId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Snapshot", "Snapshot")
                 .WithMany("SnapshotRules")
                 .HasForeignKey("SnapshotId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Junctions.SoftwareSyntax", b =>
            {
                b.HasOne("FilterLists.Data.Entities.Software", "Software")
                 .WithMany("SoftwareSyntaxes")
                 .HasForeignKey("SoftwareId")
                 .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("FilterLists.Data.Entities.Syntax", "Syntax")
                 .WithMany("SoftwareSyntaxes")
                 .HasForeignKey("SyntaxId")
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("FilterLists.Data.Entities.Snapshot", b =>
            {
                b.HasOne("FilterLists.Data.Entities.FilterList", "FilterList")
                 .WithMany("Snapshots")
                 .HasForeignKey("FilterListId")
                 .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}