select a.nim,a.nama,b.tanggal from nama a inner join jadwalmasuk b on a.nim = b.nim where b.tanggal  in ('2020-06-15','2020-06-17') order by b.tanggal asc
select a.nama,count(*) as jumlah_kehadiran from nama a inner join jadwalmasuk b on a.nim = b.nim where b.tanggal in ('2020-06-15','2020-06-17') group by a.nama order by a.nama asc
