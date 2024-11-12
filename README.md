# R1_T07_02_Niz_Z020_Histogram
R1_T07_02_Niz_Z020_Histogram

// 1 WA
// https://petlja.org/sr-Latn-RS/kurs/14606/33/2763
// https://petlja.org/sr-Cyrl-RS/kurs/14606/6/1322
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
// https://github.com/draganilicnis/R1_T07_02_Niz_Z020_Histogram/blob/main/R1_T07_02_Niz_Z020_Histogram.cs

Ни у једном програмском језику не пролази 1 тест пример (6. тест пример), осим у Паскалу.
Ради само *.pas

6. тест пример:
8,23 11,08
8
90
и још 90 реалних бројева

Дакле а = 8.23, b = 11.08, а број подеока N je 8. 
Цео опсег је b - a = 11.08 - 8.23 = 2.85.
Када цео опсег поделимо на N, односно 8 подеока требало би да добијемо: 2.85 / 8 = 0.35625,
Међутим у C# добијамо да је dx = 0.35624999999999996,
па ће код друге итерације t = t + dx (у првој ће исправно да израчуна следећу вредност t)
да за t израчуна вредност: 8.942499999999999 уместо 8.9425, 
а заокруживањем на две децимале приказаће број 8.943, што би и требало да буде исправно, међутим само Паскал ће приказати 8.942, што су уредници и навели као исправн тест пример (а није).


***
У старој збирци (https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/histogram) не пролазе 3 тест примера (WA) 3, 6 и 9, због једне додатне звездице:

У 3. тест примеру у 11 и 16. (последњем) реду:
[6.620, 7.124): 0	
[7.124, 7.629): 4	*****************
[7.629, 8.133): 0	
[8.133, 8.637): 0	
[8.637, 9.142): 1	****
[9.142, 9.646): 1	****
[9.646, 10.151): 0	
[10.151, 10.655): 2	********
[10.655, 11.159): 1	****
[11.159, 11.664): 4	*****************
[11.664, 12.168): 3	*************
[12.168, 12.672): 2	********
[12.672, 13.177): 2	********
[13.177, 13.681): 1	****
[13.681, 14.186): 0	
[14.186, 14.690): 3	*************


*********
BAT датотека: 
R1_T07_02_Niz_Z020_Histogram.exe < case-1.in > 001.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-2.in > 002.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-3.in > 003.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-4.in > 004.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-5.in > 005.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-6.in > 006.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-7.in > 007.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-8.in > 008.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-9.in > 009.txt
R1_T07_02_Niz_Z020_Histogram.exe < case-10.in > 010.txt
