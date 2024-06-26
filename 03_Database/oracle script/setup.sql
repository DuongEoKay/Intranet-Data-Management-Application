

SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS';

SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security';

EXEC LBACSYS.CONFIGURE_OLS;

EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;

SHUTDOWN IMMEDIATE;
STARTUP;





select * from v$services;

ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;

ALTER PLUGGABLE DATABASE pdbqlnb OPEN READ WRITE;


ALTER SESSION SET CONTAINER= pdbqlnb;
SHOW CON_NAME;


--create user admin
create user adm identified by a;

GRANT DBA TO adm ;


GRANT CREATE SESSION TO adm WITH ADMIN OPTION;
GRANT CREATE USER, DROP USER TO adm;
GRANT GRANT ANY ROLE TO adm;


GRANT SELECT ON DBA_TAB_PRIVS TO adm WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO adm WITH GRANT OPTION;

GRANT SELECT ON dba_tables to adm WITH GRANT OPTION;

GRANT SELECT ON dba_users to adm WITH GRANT OPTION;

GRANT SELECT ON USER_ROLE_PRIVS to adm WITH GRANT OPTION;

GRANT SELECT ON DBA_ROLES to adm WITH GRANT OPTION;


select*from dba_users where username like 'ADM%';
show con_name;



-------------------------

CREATE USER ADMIN_OLS IDENTIFIED BY 123 CONTAINER = CURRENT;
GRANT DBA TO ADMIN_OLS;
GRANT CREATE SESSION TO ADMIN_OLS WITH ADMIN OPTION;
GRANT SELECT ANY TABLE, INSERT ANY TABLE TO ADMIN_OLS;
GRANT UPDATE ANY TABLE, DELETE ANY TABLE TO ADMIN_OLS;

GRANT CREATE USER, ALTER USER, DROP USER TO ADMIN_OLS;
GRANT CREATE ROLE, DROP ANY ROLE TO ADMIN_OLS;
GRANT GRANT ANY ROLE TO ADMIN_OLS WITH ADMIN OPTION;
GRANT CREATE ANY VIEW, DROP ANY VIEW TO ADMIN_OLS;

GRANT GRANT ANY PRIVILEGE TO ADMIN_OLS WITH ADMIN OPTION;
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS;

GRANT CONNECT,RESOURCE TO ADMIN_OLS; --CẤP QUYỀN CONNECT VÀ RESOURCE
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS; --CẤP QUOTA CHO ADMIN_OLS
GRANT SELECT ANY DICTIONARY TO ADMIN_OLS; --CẤP QUYỀN ĐỌC DICTIONARY




GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_user_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_label_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO ADMIN_OLS WITH GRANT OPTION;
GRANT EXECUTE ON char_to_label TO ADMIN_OLS WITH GRANT OPTION;

GRANT LBAC_DBA TO ADMIN_OLS;
GRANT EXECUTE ON sa_sysdba TO ADMIN_OLS;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO ADMIN_OLS; -- CẤP QUYỀN THỰC THI


select* from dba_tab_privs where grantee='TKH005'
