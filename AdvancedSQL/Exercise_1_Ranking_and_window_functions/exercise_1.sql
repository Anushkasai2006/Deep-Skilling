-- ==========================================
-- Exercise 1 : Ranking and Window Functions
-- ==========================================

-- Step 1: Create Table

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Step 2: Insert Sample Data

INSERT INTO Products VALUES
(1,'Laptop A','Electronics',80000),
(2,'Laptop B','Electronics',80000),
(3,'Laptop C','Electronics',75000),
(4,'Laptop D','Electronics',70000),
(5,'Sofa A','Furniture',50000),
(6,'Sofa B','Furniture',50000),
(7,'Sofa C','Furniture',45000),
(8,'Sofa D','Furniture',40000);

---------------------------------------------------------
-- 1. ROW_NUMBER()
---------------------------------------------------------

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNum
FROM Products;

---------------------------------------------------------
-- 2. RANK() and DENSE_RANK()
---------------------------------------------------------

SELECT
    ProductID,
    ProductName,
    Category,
    Price,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNum,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRankNum

FROM Products;

---------------------------------------------------------
-- 3. Top 3 Most Expensive Products in Each Category
---------------------------------------------------------

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS rn,

        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS rk,

        DENSE_RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS drk

    FROM Products

) RankedProducts

WHERE rn <= 3;