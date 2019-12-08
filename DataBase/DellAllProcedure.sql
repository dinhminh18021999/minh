delimiter //
Create Procedure dbo.DeleteAllProcedures ()
begin
 declare _procName varchar(500) ;
 declare cur cursor for 
    select name from sys.objects where type = 'p';
DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
 open cur;
 myloop : LOOP
  fetch  cur into _procName;
  if done then 
	leave myloop;
  end if;
  if _procName <> 'DeleteAllProcedures' then 
	 drop procedure _procName;
  end if;
 end LOOP;
 close cur;
end //
delimiter ;
 Grant Execute On dbo.DeleteAllProcedures To Public;
-- drop proc  dbo.DeleteAllProcedures