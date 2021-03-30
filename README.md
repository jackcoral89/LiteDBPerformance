# LiteDBPerformance

## 🎉 How to contribute
If you want to contribute with your testing environmente, please, fork the project, build the solution and launch the program directly from the file system.
The debug session with Visual Studio causes a lower perfomances result.
Copy and paste the results from the console directly in the Readme file.

## ✔ Tests
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

Tested on:
Desktop Machine: Ryzen 3700X, 16GB Ram

```
LiteDB: default - 5000 records
==============================
Insert         :   734 ms -     6809 records/second
Bulk           :    58 ms -    85029 records/second
Update         :   348 ms -    14329 records/second
CreateIndex    :   186 ms -    26832 records/second
Query          :   367 ms -    13600 records/second
Delete         :   997 ms -     5014 records/second
Drop           :    36 ms -   138843 records/second
File Size : 11912 kb

LiteDB: encrypted - 5000 records
================================
Insert         :  4283 ms -     1167 records/second
Bulk           :    53 ms -    93968 records/second
Update         :  1456 ms -     3433 records/second
CreateIndex    :   427 ms -    11696 records/second
Query          :   320 ms -    15610 records/second
Delete         :  9465 ms -      528 records/second
Drop           :   436 ms -    11453 records/second
File Size : 11888 kb
```

Tested on:
MacBook Pro 2.6 GHz 6-Core Intel Core i7 - 16GB
```
LiteDB: default - 5000 records
==============================
Insert         :   633 ms -     7896 records/second
Bulk           :    96 ms -    51871 records/second
Update         :   297 ms -    16809 records/second
CreateIndex    :   219 ms -    22788 records/second
Query          :   391 ms -    12781 records/second
Delete         :   802 ms -     6229 records/second
Drop           :    10 ms -   457139 records/second
File Size : 12096 kb

LiteDB: encrypted - 5000 records
================================
Insert         :   583 ms -     8566 records/second
Bulk           :    72 ms -    68793 records/second
Update         :   380 ms -    13129 records/second
CreateIndex    :   170 ms -    29309 records/second
Query          :   440 ms -    11343 records/second
Delete         :  1010 ms -     4946 records/second
Drop           :     8 ms -   555648 records/second
File Size : 11840 kb
```