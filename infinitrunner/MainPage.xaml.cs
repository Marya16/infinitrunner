﻿namespace infinitrunner;

public partial class MainPage : ContentPage
{
	bool estaMorto = false;
	bool estaPulando = false;
	const int tempoEntreFrames = 25;
	int velocidade1 = 0;
    int velocidade2 = 0;
	int velocidade3 = 0;
	int velocidade = 0;
	int larguraJanela = 0;
	int alturaJanela = 0;

    protected override void OnSizeAllocated(double w, double h)
    {
       base.OnSizeAllocated(w, h);
	   CorrigeTamanhoCenerio(w, h);
	   CalculaVelocidade(w);
    }
  
  void CalculaVelocidade(double w)
  {
	velocidade1 = (int)(w* 0.001);
	velocidade2 = (int)(w* 0.004);
	velocidade3 = (int)(w* 0.008);
	velocidade = (int)(w* 0.01);
  }

  void CorrigeTamanhoCenerio(double w, double h)
  {
	foreach (var A in HSLayer1.Children)
	(A as Image).WidthRequest = w;
	foreach (var A in HSLayer2.Children)
	(A as Image).WidthRequest = w;
	foreach (var A in HSLayer3.Children)
	(A as Image).WidthRequest = w;
	foreach (var A in HSLayerChao.Children)
	(A as Image).WidthRequest = w;

	HSLayer1.WidthRequest = w;
	HSLayer2.WidthRequest = w;
	HSLayer3.WidthRequest = w;
	HSLayerChao.WidthRequest = w;

  }
}

