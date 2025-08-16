# course-plataform
A backend-focused web application for managing online courses with multi-tenancy support. It enables administrators, instructors, and students to interact with educational content securely and at scale, using role-based access and a modular architecture.

## TODO:

### Generic Features
- [ ] Generic exceptions
- [ ] Global error handler middleware
- [ ] Global validation filter

### User Features
- [ ] CRUD User
- [ ] JWT Authentication
- [ ] Authorization (role-base and claim access control)
- [ ] Password hashing (BCrypto)
- [ ] Multi-tenancy application (discriminator column, tenant context resolution by header using middleware)
- [ ] Rate limiting per user
- [ ] CPF Validation

### Signatures features (Plans/Subscriptions)
- [ ] CRUD

### Courses features
- [ ] CRUD
- [ ] Assign courses to a signature plan

### Modules features
- [ ] CRUD
- [ ] Class Status Tracking
- [ ] Track when a user starts or pauses a class
- [ ] Store current minute so users resume from where they left
- [ ] Mark class as completed with optional grade or score
- [ ] Course Progress Summary (Calculate: Total course time, Watched time, Remaining time, Completion percentage)

### Notification Features 
- [ ] Email/SMS reminders for appointments using a background service, outbox pattern.
- [ ] IHostedService and webhooks

### Payment Integration (Asaas)
- [ ] still thinking about this
- [ ] Subscription Workflow (Update payment status based on webhook)
- [ ] Payment Statuses (Pending, Paid, Failed, Canceled, Expired)

### Roles features
- [ ] Admin – Full control over CRUD and payments
- [ ] Instructor (optional) – Can create/update their own courses
- [ ] Student – Can enroll, access classes, track progress

### Caching with redis features
- [ ] still thinking about this

### Logging features
- [ ] still thinking about this (Serilog)

### Architecture and Design:
- [ ] Repository
- [ ] Clean Architecture 
- [ ] Domain Driven Design
- [ ] Command Query Responsibility Segregation
- [ ] TDD

### Database
- [ ] User table
  
### Deployment:
- [ ] CD/CI with github actions (Build & Test, Dockerize API, Push Image to GitHub Container Registry, Push Image to GitHub Container Registry)
- [ ] App Service Azure
- [ ] Key Vault
