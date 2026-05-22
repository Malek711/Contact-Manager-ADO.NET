# Contacts Management System (3-Tier Architecture)

This is a complete console-based application built with **C#** and **SQL Server (ADO.NET)** to manage contact information. This project is a practical implementation developed during my learning journey in **Course 18: Database Applications using C#** on the **Programming Advices** platform by Dr. Mohammed Abu-Hadhoud.

---

## 🚀 Project Architecture & Design Patterns

The project has evolved from a basic setup into a professional **3-Tier Architecture** to achieve strict separation of concerns, scalability, and code reusability:

1. **Presentation Layer (UI / Console App):** Manages user interactions, displays menus, and reads validated inputs.
2. **Business Layer (Business Logic):** Validates rules and links the interface directly with data access components.
3. **Data Access Layer (Data / SQL):** Handles direct SQL database connectivity via ADO.NET using parameterized queries.

* **Data Model Container:** Utilizing C# structures/classes (`stcontact` & `stCountry`) to pass clean data safely across layers.

---

## 🛠️ Features & CRUD Operations

The system implements fully decoupled **CRUD** operations through a dynamic Console Menu:

- [x] **Find Contact (Read):** Retrieves single contact records safely using IDs via `ExecuteReader`.
- [x] **Update Contact (Update):** Modifies existing database records with input validation.
- [x] **Delete Contact (Delete):** Permanently removes a contact record using secure parameterization.
- [ ] **Add New Contact (Create):** *Under development - implementing auto-increment number retrieval.*
- [ ] **List Contacts (Read All):** *Under development - fetching and mapping tables to list rows.*
- [ ] **Check Existence (IsExist):** *Under development - using `ExecuteScalar` optimization.*

### 🌍 Extra / Homework Features:
- [ ] **Countries Business & Data Access Linkage:** Designing dual architecture support for countries management.
- [ ] **Country Field Extension:** Custom database field implementation tasks.

---

## 💻 Tech Stack

* **Language:** C#
* **Database Engine:** Microsoft SQL Server
* **Data Access Framework:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`, `ExecuteScalar`)
* **Software Architecture:** 3-Tier Architecture Pattern

---

## 📈 Learning Outcomes

1. **Architectural Thinking:** Shifting from writing script-like code to decoupled, professional **3-Tier Architecture**.
2. **ADO.NET Deep Dive:** Working with raw database providers, managing connectivity leaks, and safe mapping.
3. **Secure Coding:** Implementing parameterized queries to prevent SQL Injection attempts.
4. **Git Version Control:** Tracking architectural transitions milestone-by-milestone using *Atomic Commits*.

---
*Special thanks to Dr. Mohammed Abu-Hadhoud for the structured curriculum on Programming Advices.*

================================================================================

# نظام إدارة جهات الاتصال (بنية الثلاث طبقات - 3-Tier Architecture)

تطبيق  (Console) متكامل تم بناؤه باستخدام لغة **C#** وقواعد بيانات **SQL Server** عبر تقنية **ADO.NET** لإدارة جهات الاتصال. هذا المشروع هو تطبيق عملي حقيقي تم تطويره خلال رحلتي التعليمية في **الكورس 18: تطبيقات قواعد البيانات باستخدام سي شارب** على منصة **Programming Advices** تحت إشراف الدكتور محمد أبو هدهود.

---

## 🚀 بنية المشروع وهندسة البرمجيات

لقد تطور هذا المشروع ليتعدى التقسيم البسيط ويتبنى **بنية الثلاث طبقات (3-Tier Architecture)** الاحترافية لفصل المهام تماماً وجعل الكود قابلاً للتوسع وإعادة الاستخدام:

1. **طبقة العرض (Presentation Layer - UI):** مسؤولة عن التفاعل مع المستخدم وعرض القوائم وقراءة المدخلات المدققة.
2. **طبقة منطق العمل (Business Logic Layer):** مسؤولة عن تطبيق القواعد البرمجية والربط بين شاشات المستخدم وقاعدة البيانات.
3. **طبقة الوصول للبيانات (Data Access Layer):** مسؤولة عن الاتصال المباشر بقاعدة البيانات وتنفيذ استعلامات SQL.

* **وعاء نقل البيانات:** استخدام الكائنات والهياكل (`stcontact` و `stCountry`) لتمرير البيانات النظيفة بأمان بين الطبقات الثلاث.

---

## 🛠️ الميزات وعمليات قواعد البيانات (CRUD)

يحتوي النظام على قائمة خيارات تفاعلية تدعم عمليات الـ CRUD مفصولة بالكامل بين الطبقات:

- [x] **البحث عن جهة اتصال (Find Contact):** جلب تفاصيل سجل واحد من قاعدة البيانات بأمان عبر الـ ID باستخدام `ExecuteReader`.
- [x] **تعديل جهة اتصال (Update Contact):** تعديل بيانات جهة اتصال موجودة بالفعل بعد التحقق من صحة المدخلات.
- [x] **حذف جهة اتصال (Delete Contact):** مسح سجل جهة الاتصال نهائياً باستخدام استعلامات ممررة عبر معاملات آمنة.
- [ ] **إضافة جهة اتصال جديدة (Add New Contact):** *جاري العمل عليها - تطبيق ميزة جلب الرقم التلقائي بعد الإضافة.*
- [ ] **عرض كافة جهات الاتصال (List Contacts):** *جاري العمل عليها - جلب الجداول ورسمها.*
- [ ] **التحقق من الوجود (Is Contact Exist):** *جاري العمل عليها - باستخدام ميزة `ExecuteScalar` لتحسين الأداء.*

### 🌍 ميزات إضافية (الواجبات المنزلية المقررة بالكورس):
- [ ] **تجهيز طبقات منطق وعمليات الدول (Countries Business/DataAccess):** تصميم هيكلية منفصلة لإدارة الدول.
- [ ] **توسيع حقول الدول (Add fields to Country):** تطبيق التعديلات المتقدمة على جداول الدول.

---

## 💻 التقنيات المستخدمة

* **اللغة البرمجية:** C#
* **قاعدة البيانات:** Microsoft SQL Server
* **الوصول للبيانات:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`, `ExecuteScalar`)
* **نمط البناء الهندسي:** 3-Tier Architecture

---

## 📈 المخرجات التعليمية وما تم اكتسابه

1. **التفكير الهندسي:** الانتقال من كتابة كود تتابعي بسيط إلى تقسيم التطبيق بالكامل وفق نظام **3-Tier Architecture** كالمحترفين.
2. **التمكن من ADO.NET:** فهم كيفية إدارة الاتصالات وقراءة البيانات والمحافظة على الذاكرة من التسريب.
3. **الحماية المتقدمة:** تأمين مدخلات قاعدة البيانات بالكامل ضد ثغرات SQL Injection.
4. **الاحترافية في Git:** توثيق الانتقال البرمجي والهيكلي للمشروع خطوة بخطوة عبر جيت هب باستخدام الـ *Commits المنظمة*.

---
*شكر خاص للدكتور محمد أبو هدهود على المنهج المنظم والقيم على منصة Programming Advices.*
