select sum(pendapatan) from (select cast(ROUND(a.jumlah/2,0) as decimal(15,0)) * b.harga as pendapatan 
from stock a inner join harga b on a.Anting = b.Anting) a