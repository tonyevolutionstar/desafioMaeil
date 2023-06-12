import './App.css';
import { read, utils }  from 'xlsx'; //https://docs.sheetjs.com/docs/getting-started/installation/nodejs
import React, { useState } from "react";
import DataGrid from 'react-data-grid';
import 'react-data-grid/lib/styles.css';

function App() {
  const [items, setItems] = useState([])
  
  const columns = [ 
    { key: 'Referencia', name: 'Referencia' },
    { key: 'Cliente', name: 'Cliente' },
    { key: 'Estado', name: 'Estado' },
    { key: 'Tipo', name: 'Tipo' },
    { key: 'Matricula', name: 'Matricula' },
    { key: 'TipoCarga', name: 'TipoCarga' },
    { key: 'Prioridade', name: 'Prioridade' },
    { key: 'DataRegisto', name: 'DataRegisto' },
    { key: 'BlockedTime', name: 'BlockedTime' },
    { key: 'POD', name: 'POD' },
    { key: 'Parque', name: 'Parque' },
    { key: 'TipoEquipamento', name: 'TipoEquipamento' },
    { key: 'DepotIdBlocking', name: 'DepotIdBlocking' },
    { key: 'DataAtribExp', name: 'DataAtribExp' },
    { key: 'Vessel', name: 'Vessel' },
    { key: 'Voyage', name: 'Voyage' },
    { key: 'POL', name: 'POL' }
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
      <DataGrid columns={columns} rows={items} onRowsChange={setItems} />
    </div>
  );
}

export default App;
