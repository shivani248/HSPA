export interface RegisterUser{
userName:string,
email?: string,
password: string,
mobile?:number; //Optional 
}

export interface LoginUser{
    userName:string,
    password: string,
    token : string
    }
    
