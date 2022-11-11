import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-veiculos',
  templateUrl: './veiculos.component.html',
  styleUrls: ['./veiculos.component.scss']
})
export class VeiculosComponent implements OnInit {

  public veiculos: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getVeiculos()
  }

  public getVeiculos(): void{
    this.http.get('https://localhost:7121/api/Veiculo').subscribe(
      Response => this.veiculos = Response,
      error => console.log(error)

    );
  }

}
