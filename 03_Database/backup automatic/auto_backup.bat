@echo off
rem Thiết lập biến môi trường cho Oracle
set ORACLE_SID=xe
set ORACLE_HOME=C:\app\ADMIN\product\21c\dbhomeXE\



rem Thực hiện sao lưu cơ sở dữ liệu và bản ghi log
%ORACLE_HOME%\bin\rman target / @backup.rman
