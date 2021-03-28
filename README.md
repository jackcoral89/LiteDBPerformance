# LiteDBPerformance

Tested on:
Surface Book 3 - i7, 32GB Ram

```
LiteDB: default - 5000 records
==============================
Insert         :  1193 ms -     4190 records/second
Bulk           :    77 ms -    64775 records/second
Update         :   360 ms -    13884 records/second
CreateIndex    :   201 ms -    24869 records/second
Query          :   565 ms -     8848 records/second
Delete         :  1744 ms -     2866 records/second
Drop           :    58 ms -    85846 records/second
File Size : 12088 kb

LiteDB: encrypted - 5000 records
================================
Insert         :   767 ms -     6514 records/second
Bulk           :    71 ms -    70117 records/second
Update         :   534 ms -     9357 records/second
CreateIndex    :   216 ms -    23087 records/second
Query          :   348 ms -    14340 records/second
Delete         :  1909 ms -     2618 records/second
Drop           :    58 ms -    85176 records/second
File Size : 11960 kb
```

---