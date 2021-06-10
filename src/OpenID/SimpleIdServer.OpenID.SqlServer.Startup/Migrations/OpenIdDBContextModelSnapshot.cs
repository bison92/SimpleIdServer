﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleIdServer.OpenID.EF;

namespace SimpleIdServer.OpenID.SqlServer.Startup.Migrations
{
    [DbContext(typeof(OpenIdDBContext))]
    partial class OpenIdDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OAuthConsentOAuthScope", b =>
                {
                    b.Property<string>("ConsentsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ScopesName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ConsentsId", "ScopesName");

                    b.HasIndex("ScopesName");

                    b.ToTable("OAuthConsentOAuthScope");
                });

            modelBuilder.Entity("SimpleIdServer.Jwt.JsonWebKey", b =>
                {
                    b.Property<string>("Kid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Alg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpirationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kty")
                        .HasColumnType("int");

                    b.Property<string>("OpenIdClientClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RotationJWKId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Use")
                        .HasColumnType("int");

                    b.HasKey("Kid");

                    b.HasIndex("OpenIdClientClientId");

                    b.ToTable("JsonWebKeys");
                });

            modelBuilder.Entity("SimpleIdServer.Jwt.JsonWebKeyKeyOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JsonWebKeyKid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Operation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JsonWebKeyKid");

                    b.ToTable("JsonWebKeyKeyOperation");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthClientTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OpenIdClientClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TranslationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OpenIdClientClientId");

                    b.HasIndex("TranslationId");

                    b.ToTable("OAuthClientTranslation");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthConsent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Claims")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OAuthUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OAuthUserId");

                    b.ToTable("OAuthConsent");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthScope", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExposedInConfigurationEdp")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStandardScope")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OAuthScopes");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthScopeClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsExposed")
                        .HasColumnType("bit");

                    b.Property<string>("OAuthScopeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OAuthScopeName");

                    b.ToTable("OAuthScopeClaim");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OAuthTranslation");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Claims")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceRegistrationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUserCredential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CredentialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OAuthUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OAuthUserId");

                    b.ToTable("OAuthUserCredential");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUserSession", b =>
                {
                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AuthenticationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OAuthUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("SessionId");

                    b.HasIndex("OAuthUserId");

                    b.ToTable("OAuthUserSession");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.Token", b =>
                {
                    b.Property<int>("PkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorizationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRegistrationAccessToken")
                        .HasColumnType("bit");

                    b.Property<string>("TokenType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkID");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.AuthenticationContextClassReference", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthenticationMethodReferences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Acrs");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.BCAuthorize", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NextFetchTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationEdp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RejectionSentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Scopes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BCAuthorizeLst");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.BCAuthorizePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BCAuthorizeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConsentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PermissionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BCAuthorizeId");

                    b.ToTable("BCAuthorizePermission");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.OpenIdClient", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ApplicationKind")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationTypeCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BCAuthenticationRequestSigningAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BCClientNotificationEndpoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BCTokenDeliveryMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BCUserCodeParameter")
                        .HasColumnType("bit");

                    b.Property<bool>("BackChannelLogoutSessionRequired")
                        .HasColumnType("bit");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ClientSecretExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contacts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultAcrValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DefaultMaxAge")
                        .HasColumnType("float");

                    b.Property<bool>("FrontChannelLogoutSessionRequired")
                        .HasColumnType("bit");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrantTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTokenEncryptedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTokenEncryptedResponseEnc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTokenSignedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitiateLoginUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JwksUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PairWiseIdentifierSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredTokenProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RedirectionUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RefreshTokenExpirationTimeInSeconds")
                        .HasColumnType("float");

                    b.Property<string>("RegistrationAccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestObjectEncryptionAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestObjectEncryptionEnc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestObjectSigningAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RequireAuthTime")
                        .HasColumnType("bit");

                    b.Property<string>("ResponseTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectorIdentifierUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoftwareId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoftwareVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TlsClientAuthSanDNS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TlsClientAuthSanEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TlsClientAuthSanIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TlsClientAuthSanURI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TlsClientAuthSubjectDN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TlsClientCertificateBoundAccessToken")
                        .HasColumnType("bit");

                    b.Property<string>("TokenEncryptedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenEncryptedResponseEnc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenEndPointAuthMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TokenExpirationTimeInSeconds")
                        .HasColumnType("float");

                    b.Property<string>("TokenSignedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserInfoEncryptedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInfoEncryptedResponseEnc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserInfoSignedResponseAlg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("OpenIdClients");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.OpenIdClientScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OpenIdClientClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ScopeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OpenIdClientClientId");

                    b.HasIndex("ScopeName");

                    b.ToTable("OpenIdClientScope");
                });

            modelBuilder.Entity("OAuthConsentOAuthScope", b =>
                {
                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthConsent", null)
                        .WithMany()
                        .HasForeignKey("ConsentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthScope", null)
                        .WithMany()
                        .HasForeignKey("ScopesName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleIdServer.Jwt.JsonWebKey", b =>
                {
                    b.HasOne("SimpleIdServer.OpenID.Domains.OpenIdClient", null)
                        .WithMany("JsonWebKeys")
                        .HasForeignKey("OpenIdClientClientId");
                });

            modelBuilder.Entity("SimpleIdServer.Jwt.JsonWebKeyKeyOperation", b =>
                {
                    b.HasOne("SimpleIdServer.Jwt.JsonWebKey", null)
                        .WithMany("KeyOperationLst")
                        .HasForeignKey("JsonWebKeyKid");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthClientTranslation", b =>
                {
                    b.HasOne("SimpleIdServer.OpenID.Domains.OpenIdClient", null)
                        .WithMany("Translations")
                        .HasForeignKey("OpenIdClientClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthTranslation", "Translation")
                        .WithMany()
                        .HasForeignKey("TranslationId");

                    b.Navigation("Translation");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthConsent", b =>
                {
                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthUser", null)
                        .WithMany("Consents")
                        .HasForeignKey("OAuthUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthScopeClaim", b =>
                {
                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthScope", null)
                        .WithMany("Claims")
                        .HasForeignKey("OAuthScopeName");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUserCredential", b =>
                {
                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthUser", null)
                        .WithMany("Credentials")
                        .HasForeignKey("OAuthUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUserSession", b =>
                {
                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthUser", null)
                        .WithMany("Sessions")
                        .HasForeignKey("OAuthUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.BCAuthorizePermission", b =>
                {
                    b.HasOne("SimpleIdServer.OpenID.Domains.BCAuthorize", null)
                        .WithMany("Permissions")
                        .HasForeignKey("BCAuthorizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.OpenIdClientScope", b =>
                {
                    b.HasOne("SimpleIdServer.OpenID.Domains.OpenIdClient", null)
                        .WithMany("OpenIdAllowedScopes")
                        .HasForeignKey("OpenIdClientClientId");

                    b.HasOne("SimpleIdServer.OAuth.Domains.OAuthScope", "Scope")
                        .WithMany()
                        .HasForeignKey("ScopeName")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Scope");
                });

            modelBuilder.Entity("SimpleIdServer.Jwt.JsonWebKey", b =>
                {
                    b.Navigation("KeyOperationLst");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthScope", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("SimpleIdServer.OAuth.Domains.OAuthUser", b =>
                {
                    b.Navigation("Consents");

                    b.Navigation("Credentials");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.BCAuthorize", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("SimpleIdServer.OpenID.Domains.OpenIdClient", b =>
                {
                    b.Navigation("JsonWebKeys");

                    b.Navigation("OpenIdAllowedScopes");

                    b.Navigation("Translations");
                });
#pragma warning restore 612, 618
        }
    }
}
