<h1 align="center">
Course Platform</h1>
<p align="center">
  <a href="https://github.com/marcuscfarias/course-platform/issues"><img alt="number of issues for the repository" src="https://img.shields.io/github/issues/marcuscfarias/course-platform?color=red&label=Issues&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/course-platform"><img alt="the size of the repo in kb" src="https://img.shields.io/github/repo-size/marcuscfarias/course-platform?color=orange&label=Repo-Size&style=for-the-badge" target="_blank" /></a>
  <a href="https://opensource.org/licenses/MIT"><img alt="licence the repo is published under" src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" target="_blank" /></a>
 <a href="https://github.com/marcuscfarias/course-platform/graphs/contributors"><img alt="the number of contributors on the repo" src="https://img.shields.io/github/contributors/marcuscfarias/course-platform?color=brightgreen&label=Contributors&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/course-platform/network/members"><img alt="total number of times the repo has been forked" src="https://img.shields.io/github/forks/marcuscfarias/course-platform?color=blue&label=Forks&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/course-platform/stargazers"><img alt="total number of times the repo has been starred" src="https://img.shields.io/github/stars/marcuscfarias/course-platform?color=blueviolet&label=Stars&style=for-the-badge" target="_blank" /></a>
</p>

1. About this project
   1. Description
   2. Why
   3. Demo link (other screenshots)
2. Features (table)
3. Database schema
Technologies, Frameworks, Patterns and Architecture (with image)
4. Getting started (not necessary, because already have a demo)
5. Contributing
6. License
7. Technical Explanation/Discussion

## 📋 Feature Table

| ID | Feature        |                            Description                             |  Status   |
|:--:|:--------------:|:------------------------------------------------------------------:|:---------:|
| 1  | User CRUD      |                 Create, Read, Update, Delete users                 | `✅ Done`  |
| 2  | Authentication | Secure signup, login and logout   xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx | `⏳ Planned` |
| 3  | Authorization  |              Role-based access control (Admin, User)               | `⏳ Planned` |
| 4  |                |                                                                    |             |
| 5  |                |                                                                    |             |
| 6  |                |                                                                    |             |
| 7  |                |                                                                    |             |
| 8  |                |                                                                    |             |
| 9  |                |                                                                    |             |
| 10 |                |                                                                    |             |
| 11 |                |                                                                    |             |
| 12 |                |                                                                    |             |
| 13 |                |                                                                    |             |
| 14 |                |                                                                    |             |
| 15 |                |                                                                    |             |
| 16 |                |                                                                    |             |
| 17 |                |                                                                    |             |
| 18 |                |                                                                    |             |
| 19 |                |                                                                    |             |
| 20 |                |                                                                    |             |
| 21 |                |                                                                    |             |
| 22 |                |                                                                    |             |
| 23 |                |                                                                    |             |
| 24 |                |                                                                    |             |
| 25 |                |                                                                    |             |

- o que ele faz?
- o que é? web api
- quais tecnologias usadas?
- qual ambição do projeto?
- qual estágio do projeto?
- faça tabelinha de progress
- listar coisas que não funcionam (list of uses cases that need to be improved)
- demo executavel
- documentação legivel e clara
- commits atomicos
- semantic versioning

## TODO:
### Generic Features
- [ ] Generic exceptions (structure logs with sentry)
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
- [ ] TDD (unit and integration tests)

### Database
- [ ] User table
  
### Deployment:
- [ ] CD/CI with GitHub actions (Build & Test, Dockerize API, Push Image to GitHub Container Registry, Push Image to GitHub Container Registry)
- [ ] App Service Azure
- [ ] Key Vault
- [ ] Dev and Prod environment
- [ ] config environment variables and secrets

### Documentation
- [ ] automatically generate them
