import './App.css';
import { read, utils, writeFile }  from 'xlsx'; //https://docs.sheetjs.com/docs/getting-started/installation/nodejs
import React, { useMemo, useCallback, useState, useEffect } from "react";
import { AgGridReact } from 'ag-grid-react';

function App() {
  const [items, setItems] = useState([{editable: true}])
  
  const columns = [ 
    { field: 'Referencia', width:130, resizable: true, sortable: true, filter: 'agSetColumnFilter'},
    { field: 'Cliente', width:120, resizable: true, sortable: true },
    { field: 'Estado', width:90,  resizable: true, sortable: true },
    { field: 'Tipo', width:90, resizable: true, sortable: true },
    { field: 'Matricula', width:120, resizable: true, sortable: true },
    { field: 'TipoCarga', width:120, resizable: true, sortable: true },
    { field: 'Prioridade', width:120, resizable: true, sortable: true },
    { field: 'DataRegisto', width:120, resizable: true, sortable: true },
    { field: 'BlockedTime', width:120, resizable: true, sortable: true },
    { field: 'POD', width:90, resizable: true, sortable: true },
    { field: 'Parque', width:120, resizable: true, sortable: true },
    { field: 'TipoEquipamento', width:120, resizable: true, sortable: true },
    { field: 'DepotIdBlocking', width:120, resizable: true, sortable: true },
    { field: 'DataAtribExp', width:120, resizable: true, sortable: true },
    { field: 'Vessel', width:90, resizable: true, sortable: true },
    { field: 'Voyage', width:90, resizable: true, sortable: true },
    { field: 'POL', width:90, resizable: true, sortable: true }
  ];

  const defaultColDef = useMemo(() => {
    return {
      sortable: true,
      filter: true,
      resizable: true,
      editable: true,
      flex: 1,
    };
  }, []);

  useEffect(() => {
    setItems(items)
  })

  const handleOnExport = () => {
    var wb = utils.book_new(),
    ws = utils.json_to_sheet(items);
    utils.book_append_sheet(wb, ws, "Bookings");
    writeFile(wb, "excel1_31-12-2020_updated.xlsx");
  }

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

  const onRowEditingStarted = useCallback((event) => {
    console.log('never called - not doing row editing');
  }, []);

  const onRowEditingStopped = useCallback((event) => {
    console.log('never called - not doing row editing');
  }, []);

  const onCellEditingStarted = useCallback((event) => {
    console.log('cellEditingStarted');
  }, []);

  const onCellEditingStopped = useCallback((event) => {
    console.log('cellEditingStopped');
  }, []);

  return (
    <div className="App">
      <div class="container">
        <br></br>
        <div class="row">
          <div class="col">
            <input 
                class="form-control"
                type="file"
                name="file"
                accept=".csv,.xlsx"
                onChange={handleFile}
                style = {{display:"block"}}
            ></input> 
          </div>
          <div class="col-sm">
          <button
              onClick={handleOnExport}
              style={{ marginBottom: '5px', fontWeight: 'bold' }}
            >
              Export to Excel
            </button>
        </div>
        </div>
      </div>  
      <br></br>
      <div className='ag-theme-alpine' style={{height:800, width:2000}}>
          <AgGridReact 
            rowData={items}
            columnDefs={columns}
            defaultColDef={defaultColDef}
            onRowEditingStarted={onRowEditingStarted}
            onRowEditingStopped={onRowEditingStopped}
            onCellEditingStarted={onCellEditingStarted}
            onCellEditingStopped={onCellEditingStopped}
          ></AgGridReact>
      </div>
    </div>
  );
}

export default App;
