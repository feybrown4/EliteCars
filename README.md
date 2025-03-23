# Elite Cars

## Overview

An e-commerce platform to purchase nice cars.
The platform gives a gamified experience while looking through various car options.
It also provides car modifications (pimp)

## Project Features

- User Authentication
- Cart system
- Add car to favourite
- View a list of available cars
- Search functionality
- Build A Car (Car Mod)
- Car Evaluation Calculator
- 3D Car checkout
- Gamified User interface

## Monorepo structure

```
project-root/
│── backend/
│ │
│ └── elitecars-admin/
│ │
│ └── elitecars-app/
│
│
│── UI/
│ ├── admin/
│ │
│ └── app/
│
│
└── README.md
```

## Technologies

- c# /ASP.NET Core
- NextJS
- Tailwind
- Shadcn/ui
- MSSQL Server

## Customer functions

- User authentication
- View and Search cars
- User profile
- Add car to cart
- Checkout and make payment
- Track order status
- View transactions
- View order history

## Admin Privileges

- Manage cars
  - create_car
  - view_car
  - edit_car
  - delete_car
- Manage Customers
  - view_customer
  - disable_customer
- Manage Orders
  - view_order
  - process_order
- Manage Transactions
  - view_transaction
  - process_transaction
- Manage Inventory
  - update_stock
- Manage Reports (sales and revenue)
  - view_report
- Manage Admin users
  - create_user_account
  - delete_user_account
  - update_user_account
  - create_role
  - update_role
  - delete_role
