use sqlDB;

select * from buyTbl where userID = 'JYP';
select * from userTbl where userID = 'JYP';

select buyTbl.userID, userTbl.name, buyTbl.prodName, userTbl.addr from buyTbl
	join userTbl	--join ���� : ���̺� �ٸ� ���� ���Ķ�
	on buyTbl.userID = userTbl.userID	--A + B
where buyTbl.userID = 'JYP';

select B.userID as u_id, U.name as u_name, B.price as u_price, U.addr as u_addr	--as : ���� ����
from buyTbl B
	join userTbl U	--join ���� : 
	on B.userID = U.userID	--���� ���� ���� Join�϶�
where B.userID = 'BBK';