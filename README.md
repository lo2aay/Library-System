The Library System is an application designed to manage books, users, and transactions within a library. It uses SQL for database management and C# for a user-friendly interface, enabling various operations like user management, book inventory, purchases, and comments.

Key Features:
Book Management:

Maintains a catalog with details like name, price, year, quantity, buyers, offers, author ID, and category.
Identifies the most popular book by tracking the number of buyers.
User and Reader Management:

Supports multiple roles: general users, readers, students, and admins.
Stores user details including name, ID, address, password, and phone number.
Readers and students are subsets of users; admins manage library operations.
Author Management:

Links authors to books using a unique AUTH_ID.
Identifies authors without any current books in the catalog.
Purchases and Transactions:

Records book purchases with date, reader ID, and book ID.
Finds books not purchased in the last 30 days using date-based queries.
Comments and Reviews:

Allows readers to comment on books, linking comments to specific books and readers.
Statistical Insights:

Provides data on authors whose books haven’t been purchased recently.
Identifies the most and least popular book categories.
User Activity Monitoring:

Tracks the number of books each reader buys and summarizes user activity.
