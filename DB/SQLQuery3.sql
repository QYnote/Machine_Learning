use sqlDB;

select * from buyTbl where userID = 'JYP';
select * from userTbl where userID = 'JYP';

select buyTbl.userID, userTbl.name, buyTbl.prodName, userTbl.addr from buyTbl
	join userTbl	--join 역할 : 테이블 다른 것을 합쳐라
	on buyTbl.userID = userTbl.userID	--A + B
where buyTbl.userID = 'JYP';

select B.userID as u_id, U.name as u_name, B.price as u_price, U.addr as u_addr	--as : 별명 생성
from buyTbl B
	join userTbl U	--join 역할 : 
	on B.userID = U.userID	--둘이 같은 것을 Join하라
where B.userID = 'BBK';