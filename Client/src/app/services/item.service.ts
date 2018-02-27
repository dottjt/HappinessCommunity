import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';

import { Item } from '../models';


@Injectable()
export class ItemService {
  constructor(private http: HttpClient) {}
  
  getAllItems(): Observable<Item[]> {
    return this.http.get<Item[]>('http://localhost:5000/api/cats')
  }

  getNavbarItems(): Observable<> {
    return this.http.get<>('http://localhost:5000/api/')
  }

}
