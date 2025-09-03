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

## 1. About this project

#### 1.1 Overview

This project is a backend web application built with .NET Core for managing online courses across multiple organizations, inspired by platforms like Hotmart and Kiwify. It allows educators to create and share courses, while students can access content seamlessly, with support for multiple roles and organizational structures.

The ambition of this project is to enhance my development skills and build a real-world application to showcase in my portfolio. The project is currently in development, with a functional prototype coming soon.

#### 1.2 Demo

Check the project demo in the following link: (not deployed yet)

Or you can see the photos below.

## 2. Project design

#### 2.1 Database schema

#### 2.2 Technologies

#### 3.2 Frameworks

#### 3.3 Architecture and patterns

## 3. Feature Table

~~If want more technical details about some features, you can check on technical discussion.~~

| ID |       Feature        |                 Description                 |      Status      |
|:--:|:--------------------:|:-------------------------------------------:|:----------------:|
| 1  |       Database       |   implement and draw all database schema    |   `⏳ Planned`    |
| 2  |      User CRUD       |     create, read, update, delete users      | `⚙️ In Progress` |
| 3  |    Authentication    |      secure signUp, signIn and logout       |   `⏳ Planned`    |
| 4  |    Authorization     | role-based access control and multi-tenancy |   `⏳ Planned`    |
| 5  |  Subscriptions CRUD  |                                             |   `⏳ Planned`    |
| 6  |     Courses CRUD     |                                             |   `⏳ Planned`    |
| 7  |     Modules CRUD     |                                             |   `⏳ Planned`    |
| 8  |     Classes CRUD     |                                             |   `⏳ Planned`    |
| 9  | Configuration CI/CD  |                                             |   `⏳ Planned`    |
| 10 |   Azure Deployment   |                                             |   `⏳ Planned`    |
| 11 | Notification Service |                                             |   `⏳ Planned`    |
| 12 |   Payment Service    |               Asaas or stripe               |   `⏳ Planned`    |
| 13 |   Caching strategy   |                  add redis                  |   `⏳ Planned`    |
| 14 |    Config Scalar     |        change swagger docs to scalar        |   `⏳ Planned`    |
| 15 |    IA integration    |               think about it                |   `⏳ Planned`    |
| 16 |      Front-End       |     not sure if I am going to implement     |   `⏳ Planned`    |
| 17 |                      |                                             |   `⏳ Planned`    |
| 18 |                      |                                             |   `⏳ Planned`    |
| 19 |                      |                                             |   `⏳ Planned`    |
| 20 |                      |                                             |   `⏳ Planned`    |
| 21 |                      |                                             |   `⏳ Planned`    |
| 22 |                      |                                             |   `⏳ Planned`    |
| 23 |                      |                                             |   `⏳ Planned`    |
| 24 |                      |                                             |   `⏳ Planned`    |
| 25 |                      |                                             |   `⏳ Planned`    |

## 4. Getting started

## 5. Contributing

You can send how many PR's do you want, I'll be glad to analyse and accept them! And if you have any question about the
project just ask...

## 6. License

This project is licensed under the MIT License - see
the [LICENSE.md](https://github.com/marcuscfarias/course-platform/blob/main/README.md) file for details

## 7. Technical Discussion (my own annotations, ignore below)

#### Feature 1,2,3

```
- [ ] JWT Authentication
- [ ] Authorization (role-base and claim access control)
- [ ] Password hashing (BCrypto)
- [ ] Multi-tenancy application (discriminator column, tenant context resolution by header using middleware)
- [ ] Rate limiting per user
- [ ] CPF Validation
```

### Generic Features

```
- [ ] Generic exceptions (structure logs with sentry)
- [ ] Global error handler middleware
- [ ] Global validation filter
```

### Modules features

```
- [ ] CRUD
- [ ] Class Status Tracking
- [ ] Track when a user starts or pauses a class
- [ ] Store current minute so users resume from where they left
- [ ] Mark class as completed with optional grade or score
- [ ] Course Progress Summary (Calculate: Total course time, Watched time, Remaining time, Completion percentage)
```

### Notification Features

```
- [ ] Email/SMS reminders for appointments using a background service, outbox pattern.
- [ ] IHostedService and webhooks
```

### Payment Integration (Asaas)

```
- [ ] still thinking about this
- [ ] Subscription Workflow (Update payment status based on webhook)
- [ ] Payment Statuses (Pending, Paid, Failed, Canceled, Expired)
```

### Roles features

```
- [ ] Admin – Full control over CRUD and payments
- [ ] Instructor (optional) – Can create/update their own courses
- [ ] Student – Can enroll, access classes, track progress
```

### Caching with redis features

```
- [ ] still thinking about this
```

### Logging features

```
- [ ] still thinking about this (Serilog)
```

### Architecture and Design:

```
- [ ] Repository
- [ ] Clean Architecture
- [ ] Domain Driven Design
- [ ] Command Query Responsibility Segregation
- [ ] TDD (unit and integration tests)
```

### Deployment:

```
- [ ] CD/CI with GitHub actions (Build & Test, Dockerize API, Push Image to GitHub Container Registry, Push Image to
  GitHub Container Registry)
- [ ] App Service Azure
- [ ] Key Vault
- [ ] Dev and Prod environment
- [ ] config environment variables and secrets
```

### Documentation

```
- [ ] automatically generate them
```

