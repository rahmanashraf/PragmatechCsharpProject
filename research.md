1.var dynamic object-difference
---------------------------------------------
1.1.-VAR- ne geleceyini bilmirsen ve var qoyursan her tipi qarsiliyir. ama bow buraxmag olmur.gerek nese teyin edesen evvelceden...
---------------------------------------------
1.2.-Dynamic compiler time erroru vermir..varsa error run time error verir...casting elemesende olar ama her ehtimal elemey lazimdi..
.qebul elediyin weyin metodlari iwdiyir..ToUpper ve sair....bow buraxmag olar...dynamic soz;
---------------------------------------------
1.3.-Object error varsa compiler timeda verir..casting shertdir....bow buraxmag olar...object soz;
---------------------------------------------

2. Public,private,internal,protected
Evvelce bu anlayisi qebul edek Solution daxilinde proyektler(yeni namespace), proyektlerin altinda class ve interfacelar flan yaradilir.
Public access modifieri-solution(bir nov papka) daxilinden her yerden el catan olur
Internal access modifieri-namespace daxilinde heryerden el catan olur ama solution daxilinden el catan olmur.
Protected access modifier-namespace daxilinde heryerden el catan olur amma ancag inheritance verdiyi halda classlar onu cagira bilir.sirf eyni namespace icindedi deye inherit vermibse orda accesi olmur
Private access modifier-class daxilinde ancag el catan olur ozge hec yerden el catmir


