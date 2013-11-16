
    


<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
       @Code
        @if(IsPost)
        Dim companyname = Request("CompanyName") 
        Dim contactname = Request("ContactName")
       @<p>You entered: <br><br>
        Company Name: @companyname <br> 
        Contact Name: @contactname </p>
        else
        @<form method="post" action=""> 
        Nombre de Compañia:<br><input type="text" name="CompanyName" value=""><br>
        Nombre de Contacto:<br><input type="text" name="ContactName" value=""><br><br>
        <input type="submit" value="Submit" class="submit"> 
         </form>  
       
        End If
     End Code
 
    </body>
</html>
