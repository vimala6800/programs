using Duende.IdentityServer.EntityFramework.Options;
using Duende.IdentityServer.Hosting.DynamicProviders;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Identity;
using PartnerPortal.Infrastructure.Persistence.Interceptors;
using System.Reflection;

namespace PartnerPortal.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;
		public readonly object IdentityUsers;
		public readonly object AspNetUsers;
		
			public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options, operationalStoreOptions)
        {
            _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }


        public DbSet<Partner> Partners => Set<Partner>();

        public DbSet<Functionality> Functionalities => Set<Functionality>();
        public DbSet<RolesPermission> RolePermission => Set<RolesPermission>();
        public DbSet<RoleDescription> RoleDescriptions => Set<RoleDescription>();
        public object User { get; set; }
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<RateCard> RateCards => Set<RateCard>();
        public DbSet<Requisition> requisitions => Set<Requisition>();
        public DbSet<RequisitionFile> RequisitionFiles => Set<RequisitionFile>();
        public DbSet<ProjectManager> ProjectManagers => Set<ProjectManager>();

        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Currency> Currencies => Set<Currency>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<RequisitionJD> RequisitionJDs => Set<RequisitionJD>();
        public DbSet<RequisitionPartner> RequisitionPartners => Set<RequisitionPartner>();
        public DbSet<RequisitionSkill> RequisitionSkills => Set<RequisitionSkill>();
        public DbSet<PartnerSkill> PartnerSkills => Set<PartnerSkill>();
        public DbSet<OtherRole> OtherRoles => Set<OtherRole>();


        public object IdentityUser { get; set; }
        public object RegisterUser { get; set; }
        public object Reg_user { get; set; }
        public DbSet<ProjectManagerSkill> projectManagerSkills => Set<ProjectManagerSkill>();

        public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();

        public object ApplicationUser => throw new NotImplementedException();

        public DbSet<Bench> BenchResources => Set<Bench>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedFunctionalities(builder);
            SeedOtherRoles(builder);
            SeedRoleDescriptions(builder);
            SeedUserRoles(builder);
            SeedUsers(builder);
            SeedRolePermission(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }
        public static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
            (
            new IdentityRole() { Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", Name = "Administrator", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
            new IdentityRole() { Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", Name = "ProjectManager", ConcurrencyStamp = "2", NormalizedName = "PROJECTMANAGER" },
            new IdentityRole() { Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", Name = "Partner", ConcurrencyStamp = "3", NormalizedName = "PARTNER" },
            new IdentityRole() { Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", Name = "Sales", ConcurrencyStamp = "4", NormalizedName = "SALES" }
            );
        }

        public static void SeedUsers(ModelBuilder builder)
        {

            builder.Entity<IdentityUser>().HasData
            (
            new IdentityUser() { Id = "04cf63f8-928b-4df2-a9fc-01e96f39cd80", UserName = "administrator@localhost", ConcurrencyStamp = "1", NormalizedUserName = "ADMINISTRATOR@LOCALHOST",Email="admin@fws",NormalizedEmail="ADMIN@FWS",PhoneNumber="789788789",PasswordHash="admin" },
            new IdentityUser() { Id = "4064537c-57d0-45e0-963c-d91b07ee32b2", UserName = "sales@localhost", ConcurrencyStamp = "1", NormalizedUserName = "SALES@LOCALHOST", Email = "sales@fws", NormalizedEmail = "SALES@FWS", PhoneNumber = "965718700", PasswordHash = "sales" }
            );
        }


        public static void SeedFunctionalities(ModelBuilder builder)
        {

            builder.Entity<Functionality>().HasData
            (
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0"), description = "Role Administration" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1"), description = "User Administration" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2"), description = "Skills/Profile" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3"), description = "Bench" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4"), description = "Reports" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5"), description = "Project Managers" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6"), description = "Partners" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7"), description = "Interview" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8"), description = "Resource" },
            new Functionality() { FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9"), description = "Requisition" }
            );
        }

        public static void SeedRoleDescriptions(ModelBuilder builder)
        {

            builder.Entity<RoleDescription>().HasData
            (
            new RoleDescription() { RDId = new Guid("E12B06B4-881D-4E22-1C63-08DAE7EFE031"), RoleId = "209b42b4-7d12-4680-a874-2bb5cd266dcf", RolesDescription = "PM manages projects." },
            new RoleDescription() { RDId = new Guid("421777EA-0C7E-4C35-1C64-08DAE7EFE031"), RoleId = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", RolesDescription = "Partners provide resources." },
            new RoleDescription() { RDId = new Guid("17C1B2F8-DF20-49CF-1C65-08DAE7EFE031"), RoleId = "93849f0a-2082-466c-a2bd-e23f80e2b093", RolesDescription = "Sales brings project to us." },
            new RoleDescription() { RDId = new Guid("6EB478EF-FCD6-4BA9-1C66-08DAE7EFE031"), RoleId = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", RolesDescription = "Administrator has all the authority." }
            );
        }

        public static void SeedUserRoles(ModelBuilder builder)
        {

            builder.Entity<IdentityUserRole<string>>().HasData
            (
            new IdentityUserRole<string>() { UserId = "04cf63f8-928b-4df2-a9fc-01e96f39cd80", RoleId = "e64a6efa-5bc1-4016-bbd8-be038cd6118c" },
            new IdentityUserRole<string>() { UserId = "4064537c-57d0-45e0-963c-d91b07ee32b2", RoleId = "93849f0a-2082-466c-a2bd-e23f80e2b093" }
            );
        }

        public static void SeedOtherRoles(ModelBuilder builder)
        {

            builder.Entity<OtherRole>().HasData
            (
            new OtherRole() { Address = "BTM Layout", Company = "FWS", Photo = "empty", UserId = new Guid("04cf63f8-928b-4df2-a9fc-01e96f39cd80"), ORId = new Guid("b8026d97-49ad-49f9-8f16-010ee0347dae") },
            new OtherRole() { Address = "Jayanagar", Company = "FWS", Photo = "empty", UserId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b2"), ORId = new Guid("b8026d97-49ad-49f9-8f16-010ea0348dae") }
            );
        }

        public static void SeedRolePermission(ModelBuilder builder)
        {

            builder.Entity<RolesPermission>().HasData
            (
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b1"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId= new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ea32b2"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b3"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c" , FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b4"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b5"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b6"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b7"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b8"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b9"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8") },
            new RolesPermission() {  PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b0"), Id = "e64a6efa-5bc1-4016-bbd8-be038cd6118c", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") },


            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32b2"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d81b07ee32b2"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d71b07ee32b3"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d61b07ee32b4"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d51b07ee32b5"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d41b07ee32b6"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d31b07ee32b7"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d21b07ee32b8"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d11b07ee32b9"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d01b07ee32b0"), Id = "93849f0a-2082-466c-a2bd-e23f80e2b093", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") },

            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d90b07ee32b1"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d91b07ee32c2"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d92b07ee32b3"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d93b07ee32b4"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d94b07ee32b5"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d95b07ee32b6"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d96b07ee32b7"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d97b07ee32b8"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d98b07ee32b9"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8") },
            new RolesPermission() { PId = new Guid("4064537c-57d0-45e0-963c-d99b07ee32b0"), Id = "49ce97f0-ee95-45bc-b53c-0feb4bcb0e8b", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") },

            new RolesPermission() { PId = new Guid("4004537c-57d0-45e0-963c-d91b07ee32b1"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E0") },
            new RolesPermission() { PId = new Guid("4014537c-57d0-45e0-963c-d91b07ee32b2"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E1") },
            new RolesPermission() { PId = new Guid("4024537c-57d0-45e0-963c-d91b07ee32b3"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E2") },
            new RolesPermission() { PId = new Guid("4034537c-57d0-45e0-963c-d91b07ee32b4"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E3") },
            new RolesPermission() { PId = new Guid("4044537c-57d0-45e0-963c-d91b07ee32b5"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E4") },
            new RolesPermission() { PId = new Guid("4054537c-57d0-45e0-963c-d91b07ee32b6"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E5") },
            new RolesPermission() { PId = new Guid("4060537c-57d0-45e0-963c-d91b07ee32b7"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E6") },
            new RolesPermission() { PId = new Guid("4074537c-57d0-45e0-963c-d91b07ee32b8"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E7") },
            new RolesPermission() { PId = new Guid("4084537c-57d0-45e0-963c-d91b07ee32b9"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E8") },
            new RolesPermission() { PId = new Guid("4094537c-57d0-45e0-963c-d91b07ee32b0"), Id = "209b42b4-7d12-4680-a874-2bb5cd266dcf", FId = new Guid("6FFA6BB5-06FD-4597-B39E-E465A4FC30E9") }
            );
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
