# <h1 align="center">SnakeWord</h1>
# <p>SnakeWord is searching for a word in a matrix symbol system</p>
  
I started my IT career in 2019 and one of my the first test tasks was SnakeWord. I successfully completed the task and I joined to a company. This repository has my old code of SnakeWord and I wanna write a new code for SnakeWord by my current skills.

<h2>OldSnakeWord</h2>

OldSnakeWord is a simple console program where you can enter `string wordForMatrix` value as square matrix of chars only and `string findWord` value.

```
string wordForMatrix = @"Hjx8nug hcx93[8r3h pfcj83[h3g03hfcf[8xh4ct6cphx83xh4vtchr8x 4h784j 9p12g4hf8 qh3p74gcf8gp7cf84h[9p8gchfx[2938rhg cfm[x9[crig4 ch[xn2][rh ghf43n]vt g-nf[4 8hghpf4u8n7cgt h3[4ur8gth- 3rf8ght]ran90huvjojnicgmirojhcgnuifrmiruhgtjrfpoenthu0mcgofcrenofycgjxrmougchjmicrngfhncmirnhjdfmcgirhnfvdmcgi;nsthoumdifdujnhgmjfodvshncgrpowhnbmugxrohnfgcjrofihucgj,ropivhgcmirohnumgciorfihmcgprovjntuctmirofinhmcgjiroihucgjidhmgcjithdjcgopcitrhmjcgithrmcgithrcmvigcnteriowhermxpjweiorhmgvjctoprigjc,optwihcgj,pwtiohvnpcgjwepipohngcj,xolwiexjiiwpu[wr]wqu[wripugxmofiz,w.,crmoj[ hgvcnmxfroidwc[mogipthnvmcfxqjme-fgnvnfrgtrhytotugfriepwlkfewdyqw";

string findWord = "gh3";
```

Console shows the square matrix with numbering and write a answer of character placement sequence.

```
        0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24
0       H j x 8 n u g   h c x  9  3  [  8  r  3  h     p  f  c  j  8  3
1       [ h 3 g 0 3 h f c f [  8  x  h  4  c  t  6  c  p  h  x  8  3  x
2       h 4 v t c h r 8 x   4  h  7  8  4  j     9  p  1  2  g  4  h  f
3       8   q h 3 p 7 4 g c f  8  g  p  7  c  f  8  4  h  [  9  p  8  g
4       c h f x [ 2 9 3 8 r h  g     c  f  m  [  x  9  [  c  r  i  g  4
5         c h [ x n 2 ] [ r h     g  h  f  4  3  n  ]  v  t     g  -  n
6       f [ 4   8 h g h p f 4  u  8  n  7  c  g  t     h  3  [  4  u  r
7       8 g t h -   3 r f 8 g  h  t  ]  r  a  n  9  0  h  u  v  j  o  j
8       n i c g m i r o j h c  g  n  u  i  f  r  m  i  r  u  h  g  t  j
9       r f p o e n t h u 0 m  c  g  o  f  c  r  e  n  o  f  y  c  g  j
10      x r m o u g c h j m i  c  r  n  g  f  h  n  c  m  i  r  n  h  j
11      d f m c g i r h n f v  d  m  c  g  i  ;  n  s  t  h  o  u  m  d
12      i f d u j n h g m j f  o  d  v  s  h  n  c  g  r  p  o  w  h  n
13      b m u g x r o h n f g  c  j  r  o  f  i  h  u  c  g  j  ,  r  o
14      p i v h g c m i r o h  n  u  m  g  c  i  o  r  f  i  h  m  c  g
15      p r o v j n t u c t m  i  r  o  f  i  n  h  m  c  g  j  i  r  o
16      i h u c g j i d h m g  c  j  i  t  h  d  j  c  g  o  p  c  i  t
17      r h m j c g i t h r m  c  g  i  t  h  r  c  m  v  i  g  c  n  t
18      e r i o w h e r m x p  j  w  e  i  o  r  h  m  g  v  j  c  t  o
19      p r i g j c , o p t w  i  h  c  g  j  ,  p  w  t  i  o  h  v  n
20      p c g j w e p i p o h  n  g  c  j  ,  x  o  l  w  i  e  x  j  i
21      i w p u [ w r ] w q u  [  w  r  i  p  u  g  x  m  o  f  i  z  ,
22      w . , c r m o j [   h  g  v  c  n  m  x  f  r  o  i  d  w  c  [
23      m o g i p t h n v m c  f  x  q  j  m  e  -  f  g  n  v  n  f  r
24      g t r h y t o t u g f  r  i  e  p  w  l  k  f  e  w  d  y  q  w

[0,6] => [1,6] => [1,5]
```

Only the first match can be the answer. Search match goes from LtoR TtoB. Console write `Word wasn't founded` if there is not get the match.

And OldSnakeWord solution has test project SnakeWord.Test. The project has simple assert tests.

<h2>NewSnakeWord</h2>

So, how I say I wanna write new SnakeWord solution. The project will be implemented WebUI, controllers and services. I think about adding a local database to store the results for each session and more for future sprints.
        
## First features🧐
- #### Ability to customize the matrix character
- #### Word search options
