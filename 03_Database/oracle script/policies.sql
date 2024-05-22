

SHOW CON_NAME;

--xoa cac user
create or replace procedure usp_dropuser(tbl varchar ,cols varchar )
as 
    cur SYS_REFCURSOR;
    strsql varchar(2000);
    usr varchar2(15);
begin
    open cur for 'SELECT ' || cols || ' FROM ' || tbl
        || ' WHERE ' || cols || ' in (select username from all_users)';
    loop
        fetch cur into usr;
        exit when cur%notfound;
        strsql:='drop user '||usr;
        execute immediate(strsql);
    end loop;
    close cur;
end;

exec usp_dropuser('NHANSU', 'MANV');

exec usp_dropuser('SINHVIEN', 'MASV');
/

--Tao cac user
create or replace procedure usp_createuser(tbl varchar ,cols varchar )
as 
    cur SYS_REFCURSOR;
    strsql varchar(2000);
    usr varchar2(15);
begin
    open cur for 'SELECT ' || cols || ' FROM ADM.' || tbl
        || ' WHERE ' || cols || ' not in (select username from all_users)';
    loop
        fetch cur into usr;
        exit when cur%notfound;
        strsql:='create user '||usr||' identified by a';
        execute immediate(strsql);
        strsql:='grant connect, RESTRICTED SESSION to '||usr;
        execute immediate(strsql);
        strsql:='grant create session to '||usr;
        execute immediate(strsql);
    end loop;
    close cur;
end;
/
exec usp_createuser('NHANSU', 'MANV');

exec usp_createuser('SINHVIEN', 'MASV');
/
COMMIT;

--select * from dba_users where username like 'NV%';

-------------------------------------------Phan he 2---------
CREATE OR REPLACE PROCEDURE USP_ASSIGN_ROLE(
    rl VARCHAR2, grantee VARCHAR2, tbl VARCHAR2, cols VARCHAR2
) AS
    CUR SYS_REFCURSOR;
    USR VARCHAR2(6);
BEGIN
    OPEN CUR FOR 'SELECT ' || cols || ' FROM ' || tbl
        || ' WHERE ' || cols || ' LIKE ''' || grantee || '%'' AND '
        || cols || ' IN (SELECT USERNAME FROM ALL_USERS)';
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
        EXECUTE IMMEDIATE 'GRANT ' || RL || ' TO ' || USR;
    END LOOP;
    CLOSE CUR;
END;
/


---cs1
create role rl_nhanviencoban;
/
exec USP_ASSIGN_ROLE('rl_nhanviencoban', 'NV','adm.nhansu','manv' );


/
create or replace view v_nhan_vien_co_ban
as 
    select * from nhansu
    where manv = SYS_CONTEXT('USERENV','SESSION_USER')
    with check option;
    
    
/
    
grant select,update(DT) on adm.v_nhan_vien_co_ban to rl_nhanviencoban;
grant select on adm.sinhvien to rl_nhanviencoban;
grant select on adm.donvi to rl_nhanviencoban;
grant select on adm.hocphan to rl_nhanviencoban;
grant select on adm.khmo to rl_nhanviencoban;


//select*from v_nhan_vien_co_ban;
//select * from role_tab_privs where grantee='NV0052';
//select * from dba_role_privs where grantee='NV0052';


/
---cs2
create role rl_giangvien;


exec USP_ASSIGN_ROLE('rl_nhanviencoban', 'GV','adm.nhansu','manv' );

exec USP_ASSIGN_ROLE('rl_giangvien', 'GV','adm.nhansu','manv' );
/

--select * from dba_role_privs where grantee='GV2000';

create or replace view v_giang_vien_phan_cong
as
    select * from phancong
    where magv = SYS_CONTEXT('USERENV','SESSION_USER');


/

drop view v_giang_vien_DANGKY;

create or replace view v_giang_vien_DANGKY
as
    select dk.masv , dk.diemth, dk.diemqt, dk.diemck, dk.diemtk, phancong.* from phancong, dangky dk
    where dk.magv = SYS_CONTEXT('USERENV','SESSION_USER') and dk.magv=phancong.magv
    with check option;



/


grant select on adm.v_giang_vien_phan_cong to rl_giangvien;
grant update(DIEMTH, DIEMQT, DIEMCK, DIEMTK) on adm.v_giang_vien_DANGKY to rl_giangvien;
grant select on adm.v_giang_vien_DANGKY to rl_giangvien;


-- cs3


create role rl_giaovu;
exec USP_ASSIGN_ROLE('rl_giaovu', 'GVU','adm.nhansu','manv' );
exec USP_ASSIGN_ROLE('rl_nhanviencoban', 'GVU','adm.nhansu','manv' );
/
grant select, insert, update on adm.sinhvien to rl_giaovu;
grant select, insert, update on adm.donvi to rl_giaovu;
grant select, insert, update on adm.hocphan to rl_giaovu;
grant select, insert, update on adm.khmo to rl_giaovu;

/
--select*from phancong, hocphan


create or replace view v_giao_vu_phan_cong
as
    select phancong.* from phancong, hocphan
    where phancong.mahp=hocphan.mahp and hocphan.madv='VPK'
    with check option;

--cho phep update tren bang phan cong lien quan hoc phan do van phong khoa
grant select ,update on adm.v_giao_vu_phan_cong to rl_giaovu;

--xem toan bo bang phan cong
grant select on phancong to rl_giaovu;



--select*from dangky, khmo where dangky.mahp=khmo.mahp;

/

CREATE OR REPLACE FUNCTION f_hieu_chinh_dang_ky(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := ''; DIFF FLOAT; HK CHAR(1);
    MO NUMBER(2) := TO_NUMBER(TO_CHAR(SYSDATE, 'MM'));
    YE NUMBER(4) := TO_NUMBER(TO_CHAR(SYSDATE, 'YYYY'));
BEGIN
    IF MO < 5 
    THEN HK := '1';
        DIFF :=  SYSDATE - TO_DATE('01/01/' || YE, 'DD/MM/YYYY');
    ELSIF MO < 9 
    THEN HK := '2';
         DIFF :=  SYSDATE - TO_DATE('01/05/' || YE, 'DD/MM/YYYY');
    ELSE HK := '3';
        DIFF :=  SYSDATE - TO_DATE('01/09/' || YE, 'DD/MM/YYYY');
    END IF;

    RETURN 'HK = ' || HK || ' AND NAM = ' || YE
        || 'AND 0 < ' || DIFF || ' AND ' || DIFF || '<= 14';
END;

/

BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'ADM',
                        object_name       => 'DANGKY',
                        policy_name       => 'P_GIAOVU_DANGKY');
END;


/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'DANGKY',
    POLICY_NAME  => 'P_GIAOVU_DANGKY',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'f_hieu_chinh_dang_ky',
    STATEMENT_TYPES  => 'INSERT, DELETE',
    UPDATE_CHECK => TRUE
); END;

/
grant select, insert, delete on dangky to rl_giaovu;

--cs4
create role rl_truongdonvi;

exec USP_ASSIGN_ROLE('rl_giangvien', 'TDV','adm.nhansu','manv' );
exec USP_ASSIGN_ROLE('rl_truongdonvi', 'TDV','adm.nhansu','manv' );
exec USP_ASSIGN_ROLE('rl_nhanviencoban', 'TDV','adm.nhansu','manv' );

--khong the cai view vi view duoc ghep bang nhieu bang->loai view nay k co phep insert

/
CREATE OR REPLACE FUNCTION F_TDV_PHANCONG(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := SUBSTR(USR, 1, 3);
BEGIN
    IF STR = 'GVU' THEN --ensure policy 3
        RETURN 'MAHP IN (SELECT MAHP FROM ' || P_SCHEMA || '.HOCPHAN WHERE MADV = ''VPK'')';
    ELSIF STR = 'TDV' THEN
        RETURN 'MAHP IN (SELECT MAHP FROM ' || P_SCHEMA || '.HOCPHAN
            WHERE MADV = (SELECT MADV FROM ' || P_SCHEMA || '.DONVI
                WHERE TRGDV = ''' || USR || '''))';
    ELSE
        RETURN NULL;
    END IF;
END;
/

BEGIN DBMS_RLS.DROP_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'P_TDV_PHANCONG'
); END;

/
BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'PHANCONG',
    POLICY_NAME  => 'P_TDV_PHANCONG',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_TDV_PHANCONG',
    STATEMENT_TYPES  => 'INSERT, DELETE, UPDATE',
    UPDATE_CHECK => TRUE
); END;
/
--co quyen select thi moi duoc update va delete
grant select, insert, delete, update on phancong to rl_truongdonvi;

/
create or replace view v_truongdonvi_phancong
as
    select pc.* from  nhansu ns, donvi dvi, phancong pc
    where (ns.manv like 'GV%' and ns.manv not in(select manv from nhansu where manv like 'GVU%')) and ns.manv=pc.magv and ns.madv=dvi.madv and dvi.trgdv=SYS_CONTEXT('USERENV', 'SESSION_USER')
    with check option;


/
grant select on v_truongdonvi_phancong to rl_truongdonvi

--cs5
create role rl_truongkhoa;

exec USP_ASSIGN_ROLE('rl_giangvien', 'TKH','adm.nhansu','manv' );
exec USP_ASSIGN_ROLE('rl_truongkhoa', 'TKH','adm.nhansu','manv' );
exec USP_ASSIGN_ROLE('rl_nhanviencoban', 'TKH','adm.nhansu','manv' );

/
CREATE OR REPLACE FUNCTION F_TDV_PHANCONG( --su dung chung function voi truong don vi
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := SUBSTR(USR, 1, 3);
BEGIN
    IF STR = 'GVU' OR STR = 'TKH' THEN --ensure policy 3, 5
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN WHERE MADV = ''VPK'')';
    END IF;
    IF STR = 'TDV' THEN --ensure policy 4
        RETURN 'MAHP IN (SELECT MAHP FROM HOCPHAN
            WHERE MADV = (SELECT MADV FROM DONVI
                WHERE TRGDV = ''' || USR || '''))';
    END IF;
    RETURN NULL;
END;

/
grant select, update, insert, delete on phancong to rl_truongkhoa;
/
grant select, update, insert, delete on nhansu to rl_truongkhoa;


/
CREATE OR REPLACE PROCEDURE USP_GRANT_PRIV_TRUONGKHOA AS
    CUR SYS_REFCURSOR;
    TAB VARCHAR2(10);
    USR VARCHAR(10);
    
BEGIN
    OPEN CUR FOR 'SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER=''ADM''';
    
    SELECT MANV INTO USR  FROM NHANSU WHERE MANV LIKE 'TKH%';
    LOOP
        FETCH CUR INTO TAB;
        EXIT WHEN CUR%NOTFOUND;
        EXECUTE IMMEDIATE 'GRANT SELECT ON ' || TAB || ' TO ' || USR;
    END LOOP;
    CLOSE CUR;
END;
/
EXEC USP_GRANT_PRIV_TRUONGKHOA;
/



--cs6
create role rl_sinhvien;
exec USP_ASSIGN_ROLE('rl_sinhvien', 'SV','adm.sinhvien','masv' );



BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'ADM',
                        object_name       => 'SINHVIEN',
                        policy_name       => 'P_SINHVIEN_XEM_TT');
END;

CREATE OR REPLACE FUNCTION F_SINHVIEN(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 2) = 'SV' THEN 
        RETURN 'MASV = ''' || USR || ''' ';
    END IF;

    RETURN NULL;
END; 
/

/


BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'SINHVIEN',
    POLICY_NAME  => 'P_SINHVIEN_XEM_TT',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_SINHVIEN',
    STATEMENT_TYPES  => 'SELECT'

); END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'SINHVIEN',
    POLICY_NAME  => 'P_SINHVIEN_SUA_DCHI_DT',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_SINHVIEN',
    SEC_RELEVANT_COLS =>'DCHI, DT',
    STATEMENT_TYPES  => 'UPDATE',
    UPDATE_CHECK => TRUE

); END;
/


grant select, update(dchi, dt) on sinhvien  to rl_sinhvien;
/
CREATE OR REPLACE FUNCTION F_SINHVIEN_KHMO(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    
BEGIN
    IF SUBSTR(USR, 1, 2) = 'SV' THEN 
        RETURN 'MACT = (SELECT MACT FROM SINHVIEN
            WHERE MASV = ''' || USR || ''')';
    END IF;
    RETURN NULL;
END; 

/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'KHMO',
    POLICY_NAME  => 'P_SINHVIEN_KHMO',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_SINHVIEN_KHMO',
    STATEMENT_TYPES  => 'SELECT'
); END;
/


CREATE OR REPLACE FUNCTION F_SINHVIEN_HOCPHAN(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    
BEGIN
    IF SUBSTR(USR, 1, 2) = 'SV' THEN 
        RETURN 'MAHP IN (SELECT MAHP FROM KHMO
            WHERE MACT = (SELECT MACT FROM SINHVIEN WHERE MASV = ''' || USR || '''))';
    END IF;
    RETURN NULL;
END; 


/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'HOCPHAN',
    POLICY_NAME  => 'P_SINHVIEN_HOCPHAN',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_SINHVIEN_HOCPHAN',
    STATEMENT_TYPES  => 'SELECT'
); END;
/



GRANT SELECT ON KHMO TO RL_SINHVIEN;
GRANT SELECT ON HOCPHAN TO RL_SINHVIEN;

/

CREATE OR REPLACE FUNCTION f_hieu_chinh_dang_ky(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    STR VARCHAR2(50) := ''; DIFF FLOAT; HK CHAR(1);
    MO NUMBER(2) := TO_NUMBER(TO_CHAR(SYSDATE, 'MM'));
    YE NUMBER(4) := TO_NUMBER(TO_CHAR(SYSDATE, 'YYYY'));
BEGIN

    IF MO < 5 
    THEN HK := '1';
        DIFF :=  SYSDATE - TO_DATE('01/01/' || YE, 'DD/MM/YYYY');
    ELSIF MO < 9 
    THEN HK := '2';
         DIFF :=  SYSDATE - TO_DATE('01/05/' || YE, 'DD/MM/YYYY');
    ELSE HK := '3';
        DIFF :=  SYSDATE - TO_DATE('01/09/' || YE, 'DD/MM/YYYY');
    END IF;
    IF SUBSTR(USR, 1, 2) = 'SV' THEN
        STR := 'MASV = ''' || USR || ''' AND ';
    END IF;
    RETURN STR || 'HK = ' || HK || ' AND NAM = ' || YE
        || 'AND 0 < ' || DIFF || ' AND ' || DIFF || '<= 1400000';
END;

/
CREATE OR REPLACE FUNCTION F_SINHVIEN_DANGKY(
    P_SCHEMA VARCHAR2, P_OBJ VARCHAR2
) RETURN VARCHAR2 AS
    USR VARCHAR2(6) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    IF SUBSTR(USR, 1, 2) = 'SV' THEN
        RETURN 'MASV = ''' || USR || '''';
    END IF;
    RETURN NULL;
END;
/

BEGIN DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA  => 'ADM',
    OBJECT_NAME  => 'DANGKY',
    POLICY_NAME  => 'P_SINHVIEN_DANGKY',
    FUNCTION_SCHEMA  => 'ADM',
    POLICY_FUNCTION  => 'F_SINHVIEN_DANGKY',
    STATEMENT_TYPES  => 'SELECT'
); END;
/




GRANT SELECT, INSERT,DELETE , UPDATE(MASV,MAGV, MAHP, HK, NAM, MACT) ON DANGKY TO RL_SINHVIEN;


