--B2: dang nhap bang U_AD va chay cac cau lenh sau:

--------------------AUDIT column KETLUAN trong bang HSBA--------------------


CREATE OR REPLACE FUNCTION CheckGV(pTxtUser IN VARCHAR2)
RETURN number IS
BEGIN
    IF(SUBSTR(pTxtUser,1,2) = 'GV') THEN
        IF(SUBSTR(pTxtUser,1,3) = 'GVU') THEN
         RETURN 1;
        ELSE 
         RETURN 0;
       END IF;
       END IF;
       RETURN 1;
END;
 

-- xoa policy
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'ADM',
  object_name        => 'DANGKY',
  policy_name        => 'p_AUDIT_ON_DANGKY');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'ADM',
   object_name        => 'DANGKY',
   policy_name        => 'p_AUDIT_ON_DANGKY',
   enable             =>  TRUE,
   AUDIT_COLUMN  => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',
   STATEMENT_TYPES  => 'UPDATE',
   audit_condition  => '1=CheckGV(SYS_CONTEXT(''USERENV'', ''SESSION_USER''))',
   audit_trail        =>  DBMS_FGA.DB_EXTENDED
   );
END;
/


--------------------AUDIT column KETQUA trong bang HSBA_DV--------------------
-- xoa policy
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'ADM',
  object_name        => 'NHANSU',
  policy_name        => 'p_AUDIT_ON_NHANSU');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'ADM',
   object_name        => 'NHANSU',
   policy_name        => 'p_AUDIT_ON_NHANSU',
   enable             =>  TRUE,
   AUDIT_COLUMN  => 'PHUCAP',
   STATEMENT_TYPES  => 'SELECT',
   AUDIT_CONDITION  => 'MANV <> SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
   audit_trail        =>  DBMS_FGA.DB_EXTENDED
   );
END;
/





SELECT * FROM sys.FGA_LOG$;

DELETE FROM FGA_LOG$;

 



