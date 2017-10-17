﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace funcAn
{
    public partial class Form1 : Form
    {
        int val;
        Dictionary<int, string> arrayQW = new Dictionary<int, string>();
        Dictionary<string, string> arrayANS = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            // є ∈ ∀ ∃ ⊂ → ↦ ∪ ⋂ Ā ∞ α ≤ ≥ ⇒ ⇔
            //arrayQW.Add(0, ""); 
            //arrayANS.Add("", "");
            arrayQW.Add(0, "Метрическое пространство");
            arrayANS.Add("Метрическое пространство", "множество называется метрическим пространством, если ∀ x,y ∈X задано p(x,y)≥0 :  \r\n" +
                " 1) p(x,y) = 0 ⇔ x=y  \r\n" +
                " 2) p(x,y) = p(y,x)  \r\n" +
                " 3) p(x,y) < p(x,z) + p(z,y)");

            arrayQW.Add(1, "Сходящаяся последовательность");
            arrayANS.Add("Сходящаяся последовательность", "Последовательность {Xn}⊂X называется сходящейся к x∈X, если p(Xn,X)→0, n→∞");

            arrayQW.Add(2, "Фундаментальная последовательность");
            arrayANS.Add("Фундаментальная последовательность", "последовательность {Xn}⊂X называется фундаментальной, если p(Xn,Xm)→0  n,m→∞ ");

            arrayQW.Add(3, "Полное пространство");
            arrayANS.Add("Полное пространство", "Пространство полное, если каждая фундаментальная последовательность в нем сходящаяся");

            arrayQW.Add(4, "Открытый шар");
            arrayANS.Add("Открытый шар", "Открытый шар с центром в а: B(a,r) = {x∈X: p(x,a) < r}");

            arrayQW.Add(5, "Замкнутый шар");
            arrayANS.Add("Замкнутый шар", "Замкнутый шар с центром в а: B(a,r) = {x∈X: p(x,a) ≤r}");

            arrayQW.Add(6, "Ограниченное множество");
            arrayANS.Add("Ограниченное множество", "Множество M⊂X ограничено: ∃B^(a,r): M⊂B(a,r)");

            arrayQW.Add(7, "Внутренняя точка");
            arrayANS.Add("Внутренняя точка", "M⊂X, a∈M, a- внутренняя, если ∃ r>0: B(a,r)⊂M");

            arrayQW.Add(8, "Открытое множество");
            arrayANS.Add("Открытое множество", "М - открытое множество , если все его точки внутренние");

            arrayQW.Add(9, "Предельная точка");
            arrayANS.Add("Предельная точка", "a∈X, M⊂X, a - предельная точка множества M, если ∃Xк∈M :{Xк}→a");

            arrayQW.Add(10, "Замыкание");
            arrayANS.Add("Замыкание", "Замыканием (M^) множества M : M∪{предельные точки}");

            arrayQW.Add(11, "Замкнутое множество");
            arrayANS.Add("Замкнутое множество", "Множество M замкнуто, если М = M^(⊂ все свои предельные точки) ");

            arrayQW.Add(12, "Граничная точка");
            arrayANS.Add("Граничная точка", "a∈X - граничная точка Множества M ∀ r>0 ∃x∈");


            arrayQW.Add(13, "Растояние от точки до множества");
            arrayANS.Add("Растояние от точки до множества", "a∈X, M⊂X, p(a,M)=inf{p(a,x):x∈M}");

            arrayQW.Add(14, "Расстояние между множествами");
            arrayANS.Add("Расстояние между множествами", " M⊂X, N⊂X, p(M,N)=inf(p(x,y): x∈M, y∈N}");

            arrayQW.Add(15, "Множество плотно");
            arrayANS.Add("Множество плотно", "Множество M⊂K плотно в К: К⊂M^");

            arrayQW.Add(16, "Множество всюду плотно");
            arrayANS.Add("Множество всюду плотно", "Множество M всюду плотно в пространстве X: M^ = X");

            arrayQW.Add(17, "Множество нигде не плотно");
            arrayANS.Add("Множество нигде не плотно", "Множество М нигде не плотно: ∀ шар пространства X содержит в себе некоторый шар, свободный от точек М");

            arrayQW.Add(18, "Сепарабельное пространство");
            arrayANS.Add("Сепарабельное пространство", "Пространство X называется сепарабельным , если оно содержит счётное, всюду плотное множество");

            arrayQW.Add(19, "Сжимающий оператор");
            arrayANS.Add("Сжимающий оператор", "А - Сжимающий оператор, если ∃ α*(0,1): p(Ax,Ay) ≤ αp(x,y) ∀ x,y ∈ K⊂X");

            arrayQW.Add(20, "Неподжвижная точка");
            arrayANS.Add("Неподжвижная точка", "х* - неподвижная точка оператора А если Ах* = х*");

            arrayQW.Add(21, "Принцип сжимающих отображений(Банах)");
            arrayANS.Add("Принцип сжимающих отображений(Банах)", "Принцип сжимающих отображений(Банах): Х - полное метрическое пространство, К=K^⊂X, A - сжатие, А: К↦К ⇒ ∃! неподвижная точка");

            arrayQW.Add(22, "Компактное множество");
            arrayANS.Add("Компактное множество", "Множество К метрического пространства Х называется компактным," +
                "если ∀ бесконечной последовательности {Xn} можно выбрать сходящуюся к х∈К подпоследовательнсть");

            arrayQW.Add(23, "Относительно компактное ножество");
            arrayANS.Add("Относительно компактное ножество", "Множество К относительно компактно , если K^ компактно");

            arrayQW.Add(24, "Теорема. Непрерывные функции на компактах");
            arrayANS.Add("Теорема. Непрерывные функции на компактах", "Х,У - метрические пространства с разными метриками. D⊂X, f:D↦Y, f- непрерывная" +
                "если D- компактное в X ⇒ f(D) компактное в Y");

            arrayQW.Add(25, "Теорема Вейштрасса");
            arrayANS.Add("Теорема Вейштрасса", "Y = ℝ, D⊂X - компактно, f:D↦ℝ - непрерывна ⇒ ∃ x_min, x_max ∈ D: \r\n" +
                "f(x_min) = inf f(x), x∈D; f(x_max) = sup f(x), x∈D");

            arrayQW.Add(26, "ε-сеть");
            arrayANS.Add("ε-сеть", "множество N - ε-сеть множества М, ∀ε>0 ∃yεN : p(x,y) < ε");

            arrayQW.Add(27, "Вполне ограниченное ммножество");
            arrayANS.Add("Вполне ограниченное ммножество", "Множество М вполне ограничено, если ∀ε>0 ∃компактная ε-сеть множества М");

            arrayQW.Add(28, "Теорема Хаусфорда");
            arrayANS.Add("Теорема Хаусфорда", "Х - полное метрическое пространство, К^⊂Х компактно ⇔ К - вполне ограничено");

            arrayQW.Add(29, "Линейно зависимые элементы");
            arrayANS.Add("Линейно зависимые элементы", "Элементы x_1 .. x_n метрического пространства Е называют линейно зависимыми, если ∃ C_1 .. C_n ≠ 0 одновременно, C_j∈ℝ : ∑(j=1->m)C_j*X_j = 0");

            arrayQW.Add(30, "Линейно независимые элементы");
            arrayANS.Add("Линейно независимые элементы", "Элементы x_1 .. x_n метрического пространства Е называют линейно независимыми, если  C_j∈ℝ : ∑(j=1->m)C_j*X_j =0 ⇒ С_j=0");

            arrayQW.Add(31, "n-мерное пространство");
            arrayANS.Add("n-мерное пространство", "Е - n-мерное линейное пространство (DimE=n), если ∃{x_1 .. x_n} ⊂ E - линейно независимые, а любая система из n+1 элемента - линейно зависимая");

            arrayQW.Add(32, "Бесконечномерное линейное пространство");
            arrayANS.Add("Бесконечномерное линейное пространство", "Е - Бесконечномерное линейное пространство (dimE=∞), если ∀n∈N ∃ система состоящая из n линейнонезависимых элементов");

            arrayQW.Add(33, "Линейное многообразие");
            arrayANS.Add("Линейное многообразие", "множество L⊂E называют линейным многообразием, если ∀x,y∈L ∃C_1,C_2: C_1*x + C_2*y ∈ L ");

            arrayQW.Add(34, "Афинное многообразие");
            arrayANS.Add("Афинное многообразие", "Множество М = {a} + L афинное многообразие, а≠0, L-линейное многообразие");

            arrayQW.Add(35, "Нормированное линейное пространство");
            arrayANS.Add("Нормированное линейное пространство", "Линейное пространство Е - нормированное, если определено отображение ∀х∈Е → ||x||≥0: \r\n" +
                "1) ||x||=0 ⇔ x=0; 2) ||λx||= |λ| * ||x||; 3) ||x|| + ||y|| ≥ ||x+y|| ∀x∈E, λ∈ℝ(ℂ)");

            arrayQW.Add(36, "Банахово пространство");
            arrayANS.Add("Банахово пространство", "Полное нормированное пространство ≡ Банахово пространство");

            arrayQW.Add(37, "Неравенство Юнга");
            arrayANS.Add("Неравенство Юнга", "∀u,v≥0, p>1, 1/p + 1/q = 1, u*v≤1/p*u^p +1/q*v^q");

            arrayQW.Add(38, "Неравенство Гёльдера");
            arrayANS.Add("Неравенство Гёльдера", "∑(j=1->n)|x_j*y_j|≤||x||_p*||y||_q; x= {x_1, .. , x_n}, y= {y_1, .. , y_n} 1/p+1/q = 1, p>1");

            arrayQW.Add(39, "Неравенство Минковского");
            arrayANS.Add("Неравенство Минковского", "||x+y||_p≤ ||x||_p + ||y||_p, p>1");

            arrayQW.Add(40, "Эквивалентные нормы");
            arrayANS.Add("Эквивалентные нормы", "Е - линейное нормированное пространство, ||x||_1 и ||x||_2 называют эквивалентными , если ∃α,β>0: α||x||_1≤||x||_2≤β||x||_1");

            arrayQW.Add(41, "Подпространство");
            arrayANS.Add("Подпространство", "Е- линейное нормированное пространство, подпространство Е - замкнутое линейное многообразие в Е");

            arrayQW.Add(42, "Проекция x на L");
            arrayANS.Add("Проекция x на L", "пусть x∈E, L-подпространство, x_0∈L называют проекцией x на L, если ||x-x_0|| = p(x,L)");

            arrayQW.Add(43, "Строго нормированное пространство");
            arrayANS.Add("Строго нормированное пространство", "Пространство строго нормированно, если ||x+y|| = ||x|| + ||λy|| ⇒ y = λx, λ>0");

            arrayQW.Add(44, "лемма о почти перпендикуляре");
            arrayANS.Add("лемма о почти перпендикуляре", "E - линейное нормированное пространство, L - подпространство, L≠E ∀ε>0 ∃x_ε ∉ L, ||x_ε|| = 1 : ∀x∈L:||x-x_ε||>1 - ε");

            arrayQW.Add(45, "Лок-компакт");
            arrayANS.Add("Лок-компакт", "Метрическое пространство называют лок-компактным, если ∀ ограниченное замкнутое множество в этом пространстве - компакт");

            arrayQW.Add(46, "Равностепенно непрерывные функции");
            arrayANS.Add("Равностепенно непрерывные функции", "Е=С[a,b], K⊂E. Функции из К называют равностепенно непрерывными, если ∀ε>0, x∈K ∃δ_ε>0: |t_1-t_2|<δ_ε ⇒ |x(t_1) - x(t_2)| < ε");

            arrayQW.Add(47, "Критерий АрцелА");
            arrayANS.Add("Критерий АрцелА", "Пусть К⊂С[a,b], K - относительно компактно ⇔ К-ограничено и функции из К равностепенно непрерывны.");

            arrayQW.Add(48, "Билинейная форма");
            arrayANS.Add("Билинейная форма", "Пусть V - линейное пространство. Отображение a:VxV↦ℝ называют билинейной формой, если оно линейно по каждому аргументу \r\n" +
                "a(C_1*u_1 + C_2*u_2,v) = C_1*a*(u_1,v) + C_2*a*(u_2,v) ∀u_1,u_2,v∈V, C_1, C_2∈ℝ \r\n" +
                "симметричная билинейная форма: a(u,v) = a(v,u) ∀u,v∈V \r\n" +
                "Положительная билинейная форма: а(u,u)>0 ∀ u≠0");

            arrayQW.Add(49, "Скалярное произведение");
            arrayANS.Add("Скалярное произведение", "Симметричная, положительная билинейная форма называется скалярным произведением");

            arrayQW.Add(50, "Полуторолинейная форма");
            arrayANS.Add("Полуторолинейная форма", "Пусть V - комплексное линейное пространство. a: VxV↦ℂ называется полуторолинейной формой, если по одному аргументу она линейна, \r\n" + 
                "а для второго a(u, C_1*v_1+ C_2*v_1) = c^_1*a(u,v_1) + C^_2*a(u,v_2), C^_1, C^_2 - комплексно сопряженные.");

            arrayQW.Add(51, "Самосопряженность");
            arrayANS.Add("Самосопряженность", "Самосопряженность: ∀u,v∈V a(u,v) = a(v,u)^");

            arrayQW.Add(52, "Евклидово пространство");
            arrayANS.Add("Евклидово пространство", "Линейное пространство V со скалярным произведением над полем вещественных чисел называется Евклидовым");

            arrayQW.Add(53, "Унитарное пространство");
            arrayANS.Add("Унитарное пространство", "Линейное пространство V со скалярным произведением над полем комплексных чисел называется Унитарным");

            arrayQW.Add(54, "Неравенство Коши-Буниковского");
            arrayANS.Add("Неравенство Коши-Буниковского", "Неравенство Коши-Буниковского: |(u,v)|^2 ≤ (u,u)*(v,v)");

            arrayQW.Add(55, "Гильбертово пространство");
            arrayANS.Add("Гильбертово пространство", "Пространство со скалярным произведением, полное по норме, порожденной скалярным произведением называют Гильбертовым");

            arrayQW.Add(56, "Ортогональное дополнение");
            arrayANS.Add("Ортогональное дополнение", "L^⊥ = {v∈V: (v,w)=0 ∀w∈L}");

            arrayQW.Add(57, "Теорема пифагора");
            arrayANS.Add("Теорема пифагора", "V - гильбертово пространство, V = L⊕L^⊥. ∀u∈V∃!v∈L,w∈L^⊥ : u=v+w, ||u||^2=||v||^2+||w||^2");

            arrayQW.Add(58, "Ортогональная система элементов");
            arrayANS.Add("Ортогональная система элементов", "Система элементов {x_1, .., x_n}⊂V называется ортогональной, если (x_k,x_j)=0, k≠j,x_k≠0");

            arrayQW.Add(59, "Ортонормированная система элементов");
            arrayANS.Add("Ортонормированная система элементов", "Система элементов {x_1, .., x_n}⊂V называется ортонормированной, если (x_k,x_j)= {1, k=j; 0, k≠j}");

            arrayQW.Add(60, "Равенство Парсеваля");
            arrayANS.Add("Равенство Парсеваля", "∀u∈L: ||u||^2= ∑(j)|C_j|^2, C_j(коэфициент фурье)=(u,e_j), L = span{e_1, e_2, .. }^ ");

            arrayQW.Add(61, "Неравенство Бесселя");
            arrayANS.Add("Неравенство Бесселя", "Неравенство Бесселя: ∀u∈L ||u||^2 ≥ ∑(j)|C_j|^2");

            arrayQW.Add(62, "Замкнутая система");
            arrayANS.Add("Замкнутая система", "Ортонормированная система {e_j} называется замкнутой, если является базисом для гильбертового пространства V (span{e_j}^ = V)");

            arrayQW.Add(63, "Полная система");
            arrayANS.Add("Полная система", "Ортонормированная система {e_j} называется полной, если (u,e_j)=0 ⇒ u=0 ∀j");

            arrayQW.Add(64, "Теорема о представлении линейного непрерывного функционала в гильбертовом пространстве");
            arrayANS.Add("Теорема о представлении линейного непрерывного функционала в гильбертовом пространстве",
                "f:V↦R, <f,x> - значение функционала f на элементе x∈V. \r\n " +
                "f- линеен, если <f,x+y> = <f,x> + <f,y>, <f,cx> = c<f,x>, c∈ℝ \r\n f- непрерывен, если ||x_j-x||→0 ⇒ <f,x_j>→<f,x> ");

            arrayQW.Add(65, "Непрерывный оператор");
            arrayANS.Add("Непрерывный оператор", "Пусть E,F - нормированные пространства. Оператор А:D↦F, D⊂E называется непрерывным в x_0∈D, если x_n→^E x_0, x_n∈D ⇒ Ax_n →^F Ax_0 ");

            arrayQW.Add(66, "Ограниченный оператор");
            arrayANS.Add("Ограниченный оператор", "Пусть E,F - нормированные пространства. Оператор А:D↦F, D⊂E называется ограниченым, если ∀M⊂D - ограниченного в E A(M) ограничен в F");

            arrayQW.Add(67, "Линейный оператор");
            arrayANS.Add("Линейный оператор", "A:D↦F линейный оператор, если 1) D- линейное многообразие; 2)A(C_1*x + C_2*y) = C_1*Ax + C_2*Ay ∀a_1, a_2∈ℝ, x,y∈D");

            arrayQW.Add(68, "Норма оператора");
            arrayANS.Add("Норма оператора", "Норма оператора ||A||=(x∈D||x||_E=1)sup||Ax||_f, A:D↦F, D- линейное многообразие в Е");

            arrayQW.Add(69, "Теорема. Продолжение линейного оператора по непрерывности");
            arrayANS.Add("Теорема. Продолжение линейного оператора по непрерывности",
                "E,F - линейные нормированные пространства, A:L↦F, L⊂E, L- линейное многообразие, F- полное пространство, L^ -всюду плотно в Е⇒ ∃Â:E↦F линейно неперывный оператор:" +
                "Âx = Ax, x∈L ||Â||=||A|| Â - продолжение оператора А");

            arrayQW.Add(70, "Ядро оператора");
            arrayANS.Add("Ядро оператора", "A: D↦F, ядро оператора kerA = {x∈D: Ax=0");

            arrayQW.Add(71, "Множество значений оператора");
            arrayANS.Add("Множество значений оператора", "Im(A) = A(D) - множество значений оператора А = {y∈F: ∃x∈D: Ax=y} ⊂ F");

            arrayQW.Add(72, "Левый обратный оператор");
            arrayANS.Add("Левый обратный оператор", "Пусть (Ax=Ay ⇔ x=y) - решение единственно, тогда ∃B:A(D)↦D: B*Ax = x, ∀x∈D; B - левый обратный оператор");

            arrayQW.Add(73, "Обратный оператор");
            arrayANS.Add("Обратный оператор", "Если Im(A) = F, то B определенный на всём F называется обратным оператором и обозначается A^-1: ∀x∈E A^-1Ax = x ∀y∈F A^-1Ay = y");

            arrayQW.Add(74, "Обратимый оператор");
            arrayANS.Add("Обратимый оператор", "Если Im(A) = F и kerA={0}, то A - обратим");

            arrayQW.Add(75, "Теорема. Обратимость оператора близкого к единичному");
            arrayANS.Add("Теорема. Обратимость оператора близкого к единичному", "Пусть E - банахово, α(Е) - линейный непрерывный оператор. Е↦E. Пусть A∈α(E), ||A|| < 1⇒ \r\n" +
                "⇒ ∃(I-A)^-1 ∈α(E) и ||(I-A)^-1|| ≤ 1/(1-||A||)");

            arrayQW.Add(76, "Теорема. Обратимость оператора близкого к обратимому");
            arrayANS.Add("Теорема. Обратимость оператора близкого к обратимому", "Пусть A∈α(Е)  A^-1∈α(Е)  B∈α(Е), B = A+C, ||A-B|| < 1/||A^-1||, \r\n" +
                "B = A(I+A^-1C) ⇒ ||B^-1 - A^-1|| ≤ (||A^-1||^2 * ||B-A||)/*(1-||A^-1||*||B-A||)");

            arrayQW.Add(77, "Интегральное уравнение с вырожденным ядром");
            arrayANS.Add("Интегральное уравнение с вырожденным ядром", "Интегральное уравнение с вырожденным ядром: x(t)*∫(a->b) k(t,s)x(s)ds = y(t) \r\n" +
                "Вырожденное ядро - t∈[a,b] k(t,s) = ∑(j=1->m)f_j(t)*g_j(s) \r\n" +
                "Невырожденное ядро - k(t,s) = ∑f_i(t)*g_i(s) + r(t,s), (|r| ≤ ε)");

            arrayQW.Add(78, "Теорема Банаха о гомеоморфизме");
            arrayANS.Add("Теорема Банаха о гомеоморфизме", "E,F - банаховы пространства, А:E↦F - ограниченный и обратимый линейный оператор ⇒ ∃A^-1 ∈α(F,E) линейный + непрерывный оператор. ");

            arrayQW.Add(79, "Принцип открытости отображения");
            arrayANS.Add("Принцип открытости отображения", "E,F - банаховы, A∈α(E,F), Im(A)=F, M⊂E - открытое множество ⇒ A(M)⊂F также открытое");

            arrayQW.Add(80, "Теорема о замкнутом графике");
            arrayANS.Add("Теорема о замкнутом графике", "пусть E,F - банаховы, A:E↦F - з.л.о.(замкнутый линейный оператор) ⇒ А - ограничен(непрерывен)");

            arrayQW.Add(81, "График");
            arrayANS.Add("График", "График оператора А есть множество G(A) = {Z∈E+F:Z={x,Ax},x∈D}⊂E+F");

            arrayQW.Add(82, "Замкнутый линейный оператор");
            arrayANS.Add("Замкнутый линейный оператор", "Линейный оператор A:D↦F замкнут, если график - замкнутое множество в E+F");

            arrayQW.Add(83, "Открытое отображение");
            arrayANS.Add("Открытое отображение", "Отоброажение называется открытым, если образ любого множества открыт");

            arrayQW.Add(84, "Сопряженное пространство");
            arrayANS.Add("Сопряженное пространство", "Е - линейное нормированное пространство E' = α(E,ℝ) - сопряженное с Е пространство( всегда полное т.к. ℝ - полное): \r\n" +
                "∀f∈E'↦||f||_* = sup^(||x||=1)|<f,x>|(множество линейно непрерывных функционалов)");

            arrayQW.Add(85, "Сильная сходимость");
            arrayANS.Add("Сильная сходимость", "Е- линейное нормированное пространство. Сильная сходимость: x_j ↦^E x < > > ||x_j-x|| → 0 ");

            arrayQW.Add(86, "Слабая сходимость");
            arrayANS.Add("Слабая сходимость", "Е- линейное нормированное пространство. Сильная сходимость: x_j ↦^E x < > > ∀f∈E' <f,x_j> → <f,x>");

            arrayQW.Add(87, "Сопряженный оператор");
            arrayANS.Add("Сопряженный оператор", "E,F - линейные нормированные пространства, A∈α(E,F), A:E↦F, A*:F'↦E' называют сопряженным с A оператором если ∀ x∈E, f∈F' <A*f,x> = <f,Ax>");

            arrayQW.Add(88, "Теорема Хана-Банаха");
            arrayANS.Add("Теорема Хана-Банаха", "пусть f:L↦ℝ - линейно непреывна, L⊂E - линейное многообразие. \r\n" +
                "||f||_L = sup^(||x||=1, x∈L) <f,x> < +∞ ⇒ ∃f^∈E' ∀x∈L <f^,x> = <f,x> и ||f^||_* = ||f||_L");

            arrayQW.Add(89, "Теорема Риза");
            arrayANS.Add("Теорема Риза", "пусть V - гильбертово ∀f∈V'∃! h∈V:<f,x> = (h,x) ∀x∈V||f||_* = ||h|| ");

            arrayQW.Add(90, "Компактный оператор");
            arrayANS.Add("Компактный оператор", "Оператор A:D↦F называют компактным, если образ ∀ ограниченного множества в D является относительно компактным в F");

            arrayQW.Add(91, "Вполне непрерывный оператор");
            arrayANS.Add("Вполне непрерывный оператор", "непрерывный + компактный оператор называют вполне непрерывным");

            arrayQW.Add(92, "Энергетическая форма оператора");
            arrayANS.Add("Энергетическая форма оператора", "Энергетическая форма оператора А: Q(x) = (Ax,x), sup^(||x||=1)|Q(x)=||A||");

            arrayQW.Add(93, "Инвариантность относительно оператора");
            arrayANS.Add("Инвариантность относительно оператора", "Пусть H подпространство V Если A(H)⊂H, то подпространство инвариантно относительно А");

            arrayQW.Add(94, "Пространство Соболева");
            arrayANS.Add("Пространство Соболева", "Множество W_2^1(a,b) = {f∈L^2(a,b): ∃g∈L^2(a,b) (g,u) = -(f,u') ∀u∈C_0'[a,b]} называют пространством Соболева \r\n" +
                "C_0^1[a,b] = {u(x), x∈[a,b] непрерывно дифференцируема, u(a)=u(b)=0} Функция g называется Обобщенной производной от функции f");
            // є ∈ ∀ ∃ ⊂ → ↦ ∪ ⋂ Ā ∞ α β ≤ ≥ ⇒ ⇔ ℝ ℂ ε ≠ ∑ λ δ ⊥ ⊕	Â 

            //arrayQW.Add(0, "");
            //arrayANS.Add("", "");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            val = rng.Next(94);

            textBox3.Text = arrayQW[val];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Text = arrayANS[arrayQW[val]];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
