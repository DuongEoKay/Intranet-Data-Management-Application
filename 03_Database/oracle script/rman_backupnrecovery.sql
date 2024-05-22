--kiem tra va chuyen sang archivelog
--chay trong terminal
--login sys : sqlplus / as sysdba
archive log list;

shutdown immediate;

startup mount;

alter database archivelog;


--backup database
-- vo terminal -> su dung rman
--rman target /


BACKUP DATABASE PLUS ARCHIVELOG FORMAT 'D:/backup/bu_%u';


--thay doi data de test
update adm.v_giang_vien_DANGKY set diemtk=6.90

update adm.v_giang_vien_DANGKY set diemtk=9.60



--lay gia tri cua tag vua backup
--LIST BACKUP OF DATABASE SUMMARY;



--xem audit trail de lay gia tri scn


SELECT * FROM dba_audit_trail order by EXTENDED_TIMESTAMP desc;




--recovery
RUN {
    SHUTDOWN IMMEDIATE;
    STARTUP MOUNT;
    SET UNTIL SCN 74053317;
    RESTORE DATABASE FROM TAG TAG20240430T221302;
    RECOVER DATABASE;
    ALTER DATABASE OPEN RESETLOGS;
}

