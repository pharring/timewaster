# timewaster
This is a test app that I'm using to test the (CPU bound) performance of .NET Core applications.
It runs two different algorithms for approximating normal or Gaussian distributions.
The number of iterations is settable on the command line.
There are (currently) two implementations: .NET Core and node.js

## Run .NET Core
Start in the 'dotnet' folder:
```
cd dotnet
```
Then run  with:
```
dotnet run -c Release
```
Or publish, then run:
```
dotnet publish -c Release
cd bin\Release\netcoreapp2.0\publish
dotnet timewaster.dll
```

Specify the number of iterations on the command line. e.g.
```
dotnet timewaster.dll 1000000
```

## Run node.js
Start in the 'node' folder:
```
cd node
```
Then run with:
```
node timewaster.js
```

Specify the number of iterations on the command line. e.g.
```
node timewaster.js 1000000
```

## Output
Sample output:
```
Running 100000000 iterations.
Box Muller:
                                                           ■                                                       
                                                       ■■■■■■■■■■                                                  
                                                     ■■■■■■■■■■■■■■                                                
                                                   ■■■■■■■■■■■■■■■■■■                                              
                                                 ■■■■■■■■■■■■■■■■■■■■■■                                            
                                                ■■■■■■■■■■■■■■■■■■■■■■■■                                           
                                               ■■■■■■■■■■■■■■■■■■■■■■■■■■                                          
                                             ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                        
                                            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                       
                                           ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                      
                                          ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                     
                                         ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                    
                                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                   
                                       ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                  
                                      ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                                 
                                    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                               
                                   ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                              
                                  ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                             
                                 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                            
                                ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                           
                              ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                         
                             ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                        
                           ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                      
                          ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                     
                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                  
                      ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■                 
                    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■               
                 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■            
             ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■        
        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■   
Abramowitz/Stegun:
                                                           ■                             
                                                       ■■■■■■■■■■                        
                                                    ■■■■■■■■■■■■■■■■                     
                                                   ■■■■■■■■■■■■■■■■■■                    
                                                 ■■■■■■■■■■■■■■■■■■■■■■                  
                                                ■■■■■■■■■■■■■■■■■■■■■■■■                 
                                              ■■■■■■■■■■■■■■■■■■■■■■■■■■■■               
                                             ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■              
                                            ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■             
                                           ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■            
                                          ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■           
                                         ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■          
                                       ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■        
                                      ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■       
                                     ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■      
                                    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■         
                                   ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■      
                                  ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■        
                                 ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■             
                               ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■            
                              ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■           
                             ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■         
                           ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■        
                          ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■         
                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■       
                      ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■        
                    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■         
                  ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■       
               ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■     
           ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■ 
Total time: 8369 ms
```

## Docker support
Dockerfiles are included for both Windows and Linux containers.

### .NET Core Docker image
Start in the dotnet folder:
```
cd dotnet
```

Next, build a Docker for Windows container (Nanoserver) with:
```
docker build -t timewaster:dotnet -f Dockerfile-Windows .
```
Or build a Linux (Docker for Mac, or Docker for Windows in Linux container mode) with:
```
docker build -t timewaster:dotnet -f Dockerfile-Linux .
```

Run it with:
```
docker run --rm timewaster:dotnet
```

You can specify the iterations argument on the `docker run` line too. e.g.:
```
docker run --rm timewaster:dotnet 10000
```

### node.js Docker image
Start in the node folder:
```
cd node
```

Next, build a Docker for Windows container (Nanoserver) with:
```
docker build -t timewaster:node -f Dockerfile-Windows .
```
Or build a Linux (Docker for Mac, or Docker for Windows in Linux container mode) with:
```
docker build -t timewaster:node -f Dockerfile-Linux .
```

Run it with:
```
docker run --rm timewaster:node
```

You can specify the iterations argument on the `docker run` line too. e.g.:
```
docker run --rm timewaster:node 10000
```
