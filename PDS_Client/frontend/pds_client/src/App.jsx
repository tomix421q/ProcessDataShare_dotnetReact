import { BrowserRouter } from 'react-router-dom'
import { Routes, Route } from 'react-router-dom'
import axios from 'axios'
import { useState, useEffect } from 'react'

import Home from './components/Home'
import Navbar from './components/Navbar'
import DashboardAll from './components/DashboardAll'
//
import Database from './components/Database'
import Db_eqcMachines from './components/DB_Machines/Db_eqcMachines'
import Db_asqMachines from './components/DB_Machines/Db_asqMachines'
//
import Connection from './components/Connection'
//
import MachinesInfo from './components/MachinesInfo'
import Eqc1Live from './components/machines/Eqc1Live'
import Eqc2Live from './components/machines/Eqc2Live'
import Eqc3Live from './components/machines/Eqc3Live'
import Eqc4Live from './components/machines/Eqc4Live'
import Eqc5Live from './components/machines/Eqc5Live'
import Eqc6Live from './components/machines/Eqc6Live'
import Eqc7Live from './components/machines/Eqc7Live'
import Eqc8Live from './components/machines/Eqc8Live'
import Asq2Live from './components/machines/Asq2Live'
import Asq3Live from './components/machines/Asq3Live'
import Asq4Live from './components/machines/Asq4Live'
import Asq5Live from './components/machines/Asq5Live'
import Asq6Live from './components/machines/Asq6Live'
import OpelInsertFront from './components/machines/OpelInsertFront'
import OpelInsertRear from './components/machines/OpelInsertRear'
import OpelArmrestFront from './components/machines/OpelArmrestFront'
import OpelArmrestRear from './components/machines/OpelArmrestRear'

//load config
import loadConfig from '../loadConfig'
const config = loadConfig()

const url = `http://${config.apiBaseUrl}:5147/dashboard-live-data`
function App() {
  const [data, setData] = useState([])

  // Get data
  const fetchData = async () => {
    try {
      const response = await axios(url)
      var data = await response.data
      setData(data)
      console.log(data)
    } catch (error) {
      console.log(error.response)
      setData(error.response)
    }
  }
  useEffect(() => {
    fetchData()
    const interval = setInterval(() => {
      fetchData()
    }, 20000)
    return () => clearInterval(interval)
  }, [])

  return (
    <>
      <div>
        <BrowserRouter>
          <div className='relative h-[60px]'>
            <Navbar />
          </div>
          {data == undefined && (
            <div className=' z-50 absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 bg-gray-900 w-full h-full'>
              <span className='absolute top-1/3 left-1/2 transform -translate-x-1/2 -translate-y-1/2 animate-pulse uppercase text-[6.25rem] font-bold text-red-600 border-4 p-4 border-collor1 inline-block text-center'>
                No Connection with API
                <span className='absolute -right-10 -top-10 bg-black hover:bg-collor2 hover:text-black'></span>
              </span>
            </div>
          )}

          <Routes>
            <Route path='/' element={<Home />} />
            <Route path='DashboardAll' element={<DashboardAll data={data} />} />
            {/* Machines Info */}
            <Route path='Machinesinfo' element={<MachinesInfo />}></Route>
            <Route path='Machinesinfo/Eqc1Live' element={<Eqc1Live />} />
            <Route path='Machinesinfo/Eqc2Live' element={<Eqc2Live />} />
            <Route path='Machinesinfo/Eqc3Live' element={<Eqc3Live />} />
            <Route path='Machinesinfo/Eqc4Live' element={<Eqc4Live />} />
            <Route path='Machinesinfo/Eqc5Live' element={<Eqc5Live />} />
            <Route path='Machinesinfo/Eqc6Live' element={<Eqc6Live />} />
            <Route path='Machinesinfo/Eqc7Live' element={<Eqc7Live />} />
            <Route path='Machinesinfo/Eqc8Live' element={<Eqc8Live />} />
            <Route path='Machinesinfo/Asq2Live' element={<Asq2Live />} />
            <Route path='Machinesinfo/Asq3Live' element={<Asq3Live />} />
            <Route path='Machinesinfo/Asq4Live' element={<Asq4Live />} />
            <Route path='Machinesinfo/Asq5Live' element={<Asq5Live />} />
            <Route path='Machinesinfo/Asq6Live' element={<Asq6Live />} />
            <Route path='Machinesinfo/OpelInsertFront' element={<OpelInsertFront />} />
            <Route path='Machinesinfo/OpelInsertRear' element={<OpelInsertRear />} />
            <Route path='Machinesinfo/OpelArmrestFront' element={<OpelArmrestFront />} />
            <Route path='Machinesinfo/OpelArmrestRear' element={<OpelArmrestRear />} />
            {/*  */}
            <Route path='Database' element={<Database />} />
            <Route path='database/dbeqcmachines' element={<Db_eqcMachines />}></Route>
            <Route path='database/dbasqmachines' element={<Db_asqMachines />}></Route>
            {/*  */}
            <Route path='Connection' element={<Connection data={data} />} />
          </Routes>
        </BrowserRouter>
      </div>
    </>
  )
}

export default App
