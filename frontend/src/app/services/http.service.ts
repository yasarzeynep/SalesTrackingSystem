import { Injectable } from '@angular/core';
import { ResultModel } from '../models/result.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { AuthService } from './auth.service';
import { api } from '../constants';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  error: any;

  constructor(
    private http:HttpClient,
    private auth:AuthService
  ) { }

  post<T>(apiUrl:string, body:any, callBack:(res:T)=> void,errorCallBack?:()=> void ){
    this.http.post<ResultModel<T>>(`${api}/${apiUrl}`,body,{
      headers: {
        "Authorization": "Bearer " + this.auth.token
      }
    }).subscribe({
      next: (res)=> {
        if(res.data){
          callBack(res.data);
        }        
      },
      error: (err:HttpErrorResponse)=> {
        this.error.errorHandler(err);
        if(errorCallBack){
          errorCallBack();
        }
      }
    })
  }
}