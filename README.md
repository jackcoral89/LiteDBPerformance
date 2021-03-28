# LiteDBPerformance

Tested on:
Surface Book 3 - i7, 32GB Ram

LiteDB: default - 5000 records
==============================
Insert         :  1994 ms -     2507 records/second
Bulk           :   345 ms -    14487 records/second
Update         :  1003 ms -     4981 records/second
CreateIndex    :   702 ms -     7114 records/second
Query          :  1176 ms -     4248 records/second
Delete         :  2707 ms -     1847 records/second
Drop           :   127 ms -    39255 records/second
File Size : 19208 kb

LiteDB: encrypted - 5000 records
================================
Insert         :  1789 ms -     2793 records/second
Bulk           :   330 ms -    15124 records/second
Update         :  1064 ms -     4696 records/second
CreateIndex    :   562 ms -     8884 records/second
Query          :  1291 ms -     3871 records/second
Delete         :  2678 ms -     1867 records/second
Drop           :   113 ms -    44183 records/second
File Size : 18952 kb
