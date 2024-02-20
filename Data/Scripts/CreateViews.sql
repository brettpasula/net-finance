CREATE VIEW V_CREDIT_ACCOUNT AS
    SELECT
        B.BANK_NAME,
        A.ACCOUNT_NAME,
        C.CREDIT_LIMIT,
        C.CREDIT_AVAILABLE,
        C.STATEMENT_BALANCE,
        C.STATEMENT_DUE_DATE,
        C.ANNUAL_FEE
    FROM
             ACCOUNT A
        JOIN BANK   B ON B.BANK_ID = A.BANK_ID
        JOIN CREDIT C ON C.ACCOUNT_ID = A.ACCOUNT_ID;