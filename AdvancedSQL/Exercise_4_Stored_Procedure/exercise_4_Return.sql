-- ============================================
-- Exercise 5 : Return Data from Stored Procedure
-- ============================================

-- Create Stored Procedure

DELIMITER $$

CREATE PROCEDURE sp_GetEmployeeCount
(
    IN p_DepartmentID INT
)

BEGIN

SELECT
DepartmentID,
COUNT(*) AS TotalEmployees
FROM Employees
WHERE DepartmentID = p_DepartmentID;

END $$

DELIMITER ;

-- Execute Procedure

CALL sp_GetEmployeeCount(3);