
--kiem tra
show parameter audit


-- neu audit trail la none thi chay nhung dong lenh sau de set thanh db
--alter system set audit_trail = DB,EXTENDED scope = spfile;
--shutdown immediate;
--startup;



-- AUDIT TREN TABLE
AUDIT ALL ON ADM.DANGKY BY ACCESS ;
AUDIT ALL ON ADM.DONVI BY ACCESS;
AUDIT ALL ON ADM.HOCPHAN BY ACCESS;
AUDIT ALL ON ADM.KHMO BY ACCESS;
AUDIT ALL ON ADM.NHANSU BY ACCESS  ;
AUDIT ALL ON ADM.PHANCONG BY ACCESS;
AUDIT ALL ON ADM.SINHVIEN BY ACCESS ;
AUDIT ALL ON ADM.THONGBAO BY ACCESS;



noaudit all on adm.dangky;
noaudit all on adm.DONVI;
noaudit all on adm.HOCPHAN;
noaudit all on adm.KHMO;
noaudit all on adm.NHANSU ;
noaudit all on adm.PHANCONG;
noaudit all on adm.sinhvien;
noaudit all on adm.THONGBAO;

SELECT * FROM dba_audit_trail order by EXTENDED_TIMESTAMP desc;






-- Theo doi cac hanh vi thanh cong
AUDIT ALL WHENEVER SUCCESSFUL;

-- Theo doi cac hanh vi khong thanh cong
AUDIT ALL WHENEVER NOT SUCCESSFUL;




SELECT * FROM ADM.DANGKY;
--DELETE FROM sys.aud$
-- B2: dang nhap bang U_AD, chay cau lenh sau de xem ket qua audit:
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text 
from dba_audit_trail
WHERE OBJ_NAME = 'SINHVIEN';






