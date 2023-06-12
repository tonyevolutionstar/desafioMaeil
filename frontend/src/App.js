import './App.css';
import { read, utils }  from 'xlsx'; //https://docs.sheetjs.com/docs/getting-started/installation/nodejs
import React, { useState } from "react";
import { AgGridReact } from 'ag-grid-react';


function App() {
  const [items, setItems] = useState([])
  
  const columns = [ 
    { field: 'Referencia', width:'120', resizable: true, sortable: true, filter: 'agSetColumnFilter'},
    { field: 'Cliente', width:'120', resizable: true, sortable: true },
    { field: 'Estado', width:'90',  resizable: true, sortable: true },
    { field: 'Tipo', width:'90', resizable: true, sortable: true },
    { field: 'Matricula', width:'120', resizable: true, sortable: true },
    { field: 'TipoCarga', width:'120', resizable: true, sortable: true },
    { field: 'Prioridade', width:'120', resizable: true, sortable: true },
    { field: 'DataRegisto', width:'120', resizable: true, sortable: true },
    { field: 'BlockedTime', width:'120', resizable: true, sortable: true },
    { field: 'POD', width:'90', resizable: true, sortable: true },
    { field: 'Parque', width:'120', resizable: true, sortable: true },
    { field: 'TipoEquipamento', width:'120', resizable: true, sortable: true },
    { field: 'DepotIdBlocking', width:'120', resizable: true, sortable: true },
    { field: 'DataAtribExp', width:'120', resizable: true, sortable: true },
    { field: 'Vessel', width:'90', resizable: true, sortable: true },
    { field: 'Voyage', width:'90', resizable: true, sortable: true },
    { field: 'POL', width:'90', resizable: true, sortable: true }
  ];

  const handleFile = (event) => {
    const file = event.target.files[0];
    const promisse=new Promise((resolve, reject)=>{
      const fileReader = new FileReader();
      fileReader.onload = (e) => {
        const bufferArray = e.target.result;
        const wb=read(bufferArray, {type:'array'});
        const wsname=wb.SheetNames[0];
        const ws=wb.Sheets[wsname];
        const data = utils.sheet_to_json(ws,{
          raw: false 
        });
        resolve(data);
      };
      fileReader.readAsArrayBuffer(file);

      fileReader.onerror = (error) => {
        reject(error);
      };
    });
    promisse.then((d)=>{
      console.log(d);
      setItems(d);
    });
  }

  return (
    <div className="App">
      <div class="container my-3">
        <br></br>
        <input 
            type="file"
            name="file"
            accept=".csv,.xlsx"
            onChange={handleFile}
            style = {{display:"block"}}
        ></input>
        
      </div>

      <br></br>
      <br></br>
      <div className='ag-theme-alpine-dark' style={{height:500, width:2000}}>
          <AgGridReact 
            rowData={items}
            columnDefs={columns}
          ></AgGridReact>
      </div>
   
    

    </div>
  );
}

export default App;
