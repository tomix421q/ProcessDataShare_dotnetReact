import axios from 'axios'
import { useState, useEffect } from 'react'
import { RiSignalWifiErrorFill } from 'react-icons/ri'
//load config
import loadConfig from '../../../loadConfig'
const config = loadConfig()

const url = `http://${config.apiBaseUrl}:5147/api/eqcmachines/eqc3`
const Eqc3Live = () => {
  const [data, setData] = useState([])
  const [loadingData, setLoadingData] = useState(true)
  const [comError, setComError] = useState(false)

  // GET DATA
  const fetchData = async () => {
    try {
      const response = await axios(url)
      var data = await response.data
      setData(data)
      setLoadingData(false)
      if (data.error || data.connection !== 'Connection OK') {
        setComError(true)
      } else {
        setComError(false)
      }
      console.log(data)
    } catch (error) {
      console.log(error.response)
      setLoadingData(false)
      setComError(true)
    }
  }
  useEffect(() => {
    fetchData()
    const interval = setInterval(() => {
      fetchData()
    }, 5000)
    return () => clearInterval(interval)
  }, [])

  return (
    <div className=' section max-w-[1500px] mx-auto'>
      <div className='mx-6 justify-center items-center h-auto w-full flex flex-col'>
        {/* CONNECTION ERROR */}
        <div className={`${comError ? 'flex' : 'hidden'} flex-col justify-center items-center mb-10 w-full`}>
          <div className='max-w-[800px] flex flex-col  bg-black text-collor2 p-4 md:p-16 rounded-md shadow-xl shadow-black gap-y-6 '>
            <h1 className='text-5xl md:text-8xl w-full border-b border-secondary font-bold flex my-auto items-center justify-between'>
              Connection Error...{' '}
              <span>
                <RiSignalWifiErrorFill className='text-secondary p-2 size-24 md:size-40' />
              </span>
            </h1>
            <h2 className='text-xl md:text-3xl text-left  text-primary uppercase tracking-tight'>
              {data.error ? data.error : data.connection}
            </h2>
          </div>
        </div>
        {/*  */}
        {/* LOADING */}
        <div className={`${loadingData ? 'flex' : 'hidden'} flex-col justify-center items-center w-full`}>
          <div className='max-w-[800px] bg-secondary text-collor2 flex  p-4 md:p-16 rounded-md shadow-xl shadow-black gap-y-6'>
            <h1 className='text-5xl md:text-8xl w-full border-b border-secondary font-bold my-auto'>Trying to connect...</h1>
            <img src='/loading.svg' alt='loading data' className='size-[100px] md:size-[200px]' />
          </div>
        </div>
        {/*  */}
        {/* DATA */}
        <div className={`${!comError && !loadingData ? 'flex' : 'hidden'} w-full`}>
          <div className='w-full'>
            {/* head  */}
            <div className='text-center border-b border-collor1 border shadow-2xl shadow-black rounded-lg bg-gray-800'>
              <h1 className='text-4xl md:text-8xl text-collor2 font-thin font-extraFont rounded-lg pt-2'>EQC MF 3</h1>
              <h4 className='text-sm md:text-lg mb-2 uppercase'>
                <span>{data.actualDowntime == 0 ? 'InProduction' : 'Downtime: ' + data.actualDowntime + ' min'}</span>
              </h4>
            </div>
            {/* body  */}
            <div className='flex flex-col lg:flex-row my-8 gap-y-4 justify-between'>
              {/* Machine  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Machine</h2>
                <p>
                  Tool number : <span className='font-bold text-secondary text-xl'>{data.toolNumber}</span>
                </p>
                <p>
                  Tool name : <span className='font-bold text-secondary text-xl'>{data.actualToolName}</span>
                </p>
                <p>
                  Production current num : <span className='font-bold text-secondary text-xl'>{data.productionCurrentNum}</span>
                </p>
                <p>
                  Machine auto : <span className='font-bold text-secondary text-xl'>{data.machineAuto ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Actual cycle time : <span className='font-bold text-secondary text-xl'>{data.cycleTime} sec</span>
                </p>
                <p>
                  Step number : <span className='font-bold text-secondary text-xl'>{data.mainStepNumber}</span>
                </p>
                <p>
                  Conveyor ok : <span className='font-bold text-secondary text-xl'>{data.conveyorOK ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Heater ok : <span className='font-bold text-secondary text-xl'>{data.heaterOk ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Tool home : <span className='font-bold text-secondary text-xl'>{data.toolHome ? 'yes' : 'no'}</span>
                </p>
              </div>
              {/* Gluestation  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>
                  Glue station
                </h2>
                <p>
                  Bluemelt ok : <span className='font-bold text-secondary text-xl'>{data.bluemeltOk ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Actual pressure : <span className='font-bold text-secondary text-xl'>{data.actualPressure}</span>
                </p>
                <p>
                  Actual air inside 1 : <span className='font-bold text-secondary text-xl'>{data.actual_AirInside1}</span>
                </p>
                <p>
                  Actual air outside 1 : <span className='font-bold text-secondary text-xl'>{data.actual_AirOutside1}</span>
                </p>
                <p>
                  Actual air inside 2 : <span className='font-bold text-secondary text-xl'>{data.actual_AirInside2}</span>
                </p>
                <p>
                  Actual air outside 2 : <span className='font-bold text-secondary text-xl'>{data.actual_AirOutside1}</span>
                </p>
                <p>
                  Actual air inside 3 : <span className='font-bold text-secondary text-xl'>{data.actual_AirInside3}</span>
                </p>
                <span className='bg-collor1/50 w-[50%] mx-auto  h-[1px] decoration-dashed block rounded-full'></span>
                <p>
                  Set air inside 1 : <span className='font-bold text-secondary text-xl'> {data.setAirInside1}</span>
                </p>
                <p>
                  Set air outside 1 : <span className='font-bold text-secondary text-xl'> {data.setAirOutside1}</span>
                </p>
                <p>
                  Set pump speed 1 : <span className='font-bold text-secondary text-xl'> {data.setpumpSpeed1}</span>
                </p>
                <p>
                  Set air inside 2 : <span className='font-bold text-secondary text-xl'> {data.setAirInside2}</span>
                </p>
                <p>
                  Set air outside 2 : <span className='font-bold text-secondary text-xl'> {data.setAirOutside2}</span>
                </p>
                <p>
                  Set pump speed 2 : <span className='font-bold text-secondary text-xl'> {data.setpumpSpeed2}</span>
                </p>
                <p>
                  Set pump speed 3 : <span className='font-bold text-secondary text-xl'> {data.setpumpSpeed3}</span>
                </p>
              </div>
              {/* Robot  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Robot info</h2>
                <p>
                  Auto : <span className='font-bold text-secondary text-xl'>{data.robotAutomaticMode ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Robot home : <span className='font-bold text-secondary text-xl'>{data.robotHome ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Robot running : <span className='font-bold text-secondary text-xl'>{data.robotRunning ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Tool number : <span className='font-bold text-secondary text-xl'>{data.robotToolNumber}</span>
                </p>
                <p>
                  Gripper connected :{' '}
                  <span className='font-bold text-secondary text-xl'>{data.robotConnectedGripper ? 'yes' : 'no'}</span>
                </p>
              </div>
            </div>
          </div>
        </div>
        {/*  */}
      </div>
    </div>
  )
}
export default Eqc3Live
