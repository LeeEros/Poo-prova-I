using System;
using System.Globalization;

namespace logistica
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro carro = new Carro();
			
			carro.PosicaoVeiculo();
			
			carro.situacaoMecanicaVeiculo();

			carro.combustivelVeiculo();
			
			carro.velocidadeVeiculo();
			
			carro.bloqueioTransitoVeiculo();
		}
	}
}