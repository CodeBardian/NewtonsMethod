# NewtonsMethod
calculate solution of nonlinear equation system numerically


the algorithm uses newtons method to solve a non-linear equation system with 2 equations and 2 variables:

<a href="https://www.codecogs.com/eqnedit.php?latex=\binom{x_1^2&space;&plus;&space;x_2}{x_1&plus;x_2^2}=&space;\binom{11}{7}" target="_blank"><img src="https://latex.codecogs.com/gif.latex?\binom{x_1^2&space;&plus;&space;x_2}{x_1&plus;x_2^2}=&space;\binom{11}{7}" title="\binom{x_1^2 + x_2}{x_1+x_2^2}= \binom{11}{7}" /></a>

Note: partial derivate of your equation system needs to be calculated beforehand to change line 32 accordingly.
In the example that would be:

<a href="https://www.codecogs.com/eqnedit.php?latex=\binom{x_1^2&space;&plus;&space;x_2&space;-11}{x_1&plus;x_2^2&space;-7}=&space;\binom{0}{0}\rightarrow&space;Df(\vec{x})=\binom{2\,\,x_1&space;&plus;1}{1&plus;2\,&space;x_2}" target="_blank"><img src="https://latex.codecogs.com/gif.latex?\binom{x_1^2&space;&plus;&space;x_2&space;-11}{x_1&plus;x_2^2&space;-7}=&space;\binom{0}{0}\rightarrow&space;Df(\vec{x})=\binom{2\,\,x_1&space;&plus;1}{1&plus;2\,&space;x_2}" title="\binom{x_1^2 + x_2 -11}{x_1+x_2^2 -7}= \binom{0}{0}\rightarrow Df(\vec{x})=\binom{2\,\,x_1 +1}{1+2\, x_2}" /></a>
