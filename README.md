
# YourMedia 

YourMedia is an online review platform for movies and series, inspired by IMDb but designed as a database systems project.  
It allows registered users to **rate, review, and organize media content**, while ensuring data consistency, normalization, and security in the backend.

 **Demo video:** [Watch on YouTube](https://youtu.be/3CTDktONccw)

----------

##  Features

-    Register and login with **encrypted credentials**
    
-    Rate movies and series (0–10 scale)
    
-    Write and read reviews
    
-    Vote on other users’ reviews (upvotes & downvotes)
    
-    Add items to **Watchlist** (“See Later” list)
    
-    Sort content by release date, name, or rating
    
-    Search for movies and series
    
-    View information about actors, crew, categories, and ratings (IGAC classification)
    

----------

##  Database Design

The project was developed with a strong focus on **database principles**:

-   **ER Model & Relational Schema**

![Alt text](esquemas/ER.jpg)
(Entity-Relationship Model)

![Alt text](esquemas/DER.jpg)
(ER Diagram)
    
-   **Third Normal Form (3NF)**
    
-   **SQL DML** operations for data manipulation
    
-   **Triggers** (e.g., auto-updating movie rating when a new review is added)
    
-   **Stored Procedures** (e.g., login, register, review insertion, watchlist management)
    
-   **User Defined Functions** (e.g., fetch actors by movie, list reviews by user)
    

----------

##  Security

-   Passwords are stored using **SHA-256 encryption**.
    
-   Login and registration procedures ensure no collisions and safe authentication.
    

----------

##  Project Structure

-   **Database scripts:** SQL DDL, DML, triggers, stored procedures, UDFs
    
-   **Interface:** A simple UI to interact with the database (search, review, manage watchlist)
    
-   **Report:** Full documentation of database design and implementation
    

----------

##  Team

Developed as part of the **Database Project** course at Universidade de Aveiro:

-   Nuno Cunha (98124)
    
-   Filipe Silveira (97981)
    

----------

##  Conclusion

YourMedia demonstrates how a database-driven application can handle complex relationships between users, media content, and reviews, while ensuring **data integrity, security, and usability**.

----------