# Mix-two-signals-in-CSharp

This is an implementation designed in C#. Each implementation is able to mix two signals/vectors (A and B) in arbitrary proportions.

This source code uses a novel mathematical model published in the journal [Chaos](https://aip.scitation.org/doi/10.1063/1.5120818). The model is called Spectral Forecast.

is a demo application designed in Javascript, that is able to mix two signals (<i>A</i> and <i>B</i>) in arbitrary proportions. Different cases can be seen, with two different waveform signals that are combined depending on a value <i>d</i>, called a distance. This distance <i>d</i> can be arbitrary chosen between zero and a value Max(d), which is defined as the maximum value found above the two vectors that represent these signals. Note: The two HTML files (<kbd>index.html</kbd> and <kbd>waveform mixing with Spectral Forecast.html</kbd>) have the same content. The presence of the <kbd>index.html</kbd> file is required for the [live demo](https://gagniuc.github.io/Waveform-mixing-with-Spectral-Forecast-in-JS/) (Github specific). Here's how to use the Spectral Forecast equation to combine two waveforms:


![screenshot](https://github.com/Gagniuc/Waveform-mixing-with-Spectral-Forecast-in-JS/blob/main/img/spectral%20forecast%20signals.png?raw=true)

The effect of the above code for longer signals can be seen in a graphical form below: https://gagniuc.github.io/Waveform-mixing-with-Spectral-Forecast-in-JS/

![screenshot](https://github.com/Gagniuc/Waveform-mixing-with-Spectral-Forecast-in-JS/blob/main/img/sf(0).gif?raw=true)

![screenshot](https://github.com/Gagniuc/Waveform-mixing-with-Spectral-Forecast-in-JS/blob/main/img/sf(2).gif?raw=true)

![screenshot](https://github.com/Gagniuc/Waveform-mixing-with-Spectral-Forecast-in-JS/blob/main/img/sf(3).gif?raw=true)



# References

<i>Paul A. Gagniuc et al. Spectral forecast: A general purpose prediction model as an alternative to classical neural networks. Chaos 30, 033119 (2020).</i>

<i>Paul A. Gagniuc. Algorithms in Bioinformatics: Theory and Implementation. John Wiley & Sons, Hoboken, NJ, USA, 2021, ISBN: 9781119697961.</i>
