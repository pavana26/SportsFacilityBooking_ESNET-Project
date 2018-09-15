echo "start setup"
sqlcmd -i DBsetup.sql

echo "Insert Members"
sqlcmd -i InsertScripts/InsertMembers.sql

echo "Insert Facilities"
sqlcmd -i InsertScripts/InsertFacilities.sql

echo "Insert Transactions"
sqlcmd -i InsertScripts/InsertTransactions.sql

echo "Insert Availability"
sqlcmd -i InsertScripts/InsertAvailability.sql

