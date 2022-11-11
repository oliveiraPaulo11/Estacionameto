import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-veiculos',
  templateUrl: './veiculos.component.html',
  styleUrls: ['./veiculos.component.scss']
})
export class VeiculosComponent implements OnInit {

  public veiculos: any = [];
  public veiculosFiltrados: any = []

  private _filtroLista: string = "";

  public get filtroLista() : string{
    return this._filtroLista;
  }
  public set filtroLista(value: string){
    this._filtroLista = value;
    this.veiculosFiltrados = this.filtroLista ? this.filtrarVeiculos(this.filtroLista) : this.veiculos;
  }

  filtrarVeiculos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.veiculos.filter(
    (veiculo: any) => veiculo.placaDoVeiculo.toLocaleLowerCase().indexOf(filtrarPor)!== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getVeiculos()
  }

  public getVeiculos(): void{
    this.http.get('https://localhost:7121/api/Veiculo').subscribe(
      Response => {
        this.veiculos = Response,
        this.veiculosFiltrados = this.veiculos
      },
      error => console.log(error)
      );
  }

}
