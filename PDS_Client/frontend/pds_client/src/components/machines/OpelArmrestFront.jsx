import axios from 'axios'
import { useState, useEffect } from 'react'
import { RiSignalWifiErrorFill } from 'react-icons/ri'
//load config
import loadConfig from '../../../loadConfig'
const config = loadConfig()

const url = `http://${config.apiBaseUrl}:5147/api/opelmachines/armrestfront`

const OpelArmrestFront = () => {
  const [data, setData] = useState([])
  const [loadingData, setLoadingData] = useState(true)
  const [comError, setComError] = useState(false)
  const [showPicture, setShowPicture] = useState(false)

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
          <div className='max-w-[800px] flex flex-col  bg-black text-collor2 p-4 md:p-16 rounded-md shadow-xl shadow-black gap-y-6 border-collor1 border'>
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
        <div className={`${loadingData ? 'flex' : 'hidden'} flex-col justify-center items-center w-full `}>
          <div className='max-w-[800px] bg-secondary text-collor2 flex  p-4 md:p-16 rounded-lg shadow-xl shadow-black gap-y-6 border-collor1 border'>
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
              <h1 className='text-4xl md:text-8xl text-collor2 font-thin font-extraFont rounded-lg py-2'>Opel Armrest Front</h1>
              <h4 className='text-sm md:text-lg mb-2 uppercase flex justify-center flex-col md:flex-row md:gap-x-10'>
                <div>
                  <span className='text-secondary'>
                    {data.actualDowntime == 0 ? ' InProduction' : ' Downtime: ' + data.actualDowntime + ' min'}
                  </span>
                </div>
              </h4>
            </div>
            {/* body  */}
            <div className='flex flex-col lg:flex-row my-8 gap-y-4 justify-center gap-x-24'>
              {/* Global  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Global</h2>
                <p>
                  Mould number : <span className='font-bold text-secondary text-xl'>{data.mouldNumber}</span>
                </p>
                <p>
                  Left parts : <span className='font-bold text-secondary text-xl'>{data.leftPart} </span>
                </p>
                <p>
                  Right parts : <span className='font-bold text-secondary text-xl'>{data.rightPart} </span>
                </p>
                <p>
                  Recipe : <span className='font-bold text-secondary text-xl'>{data.recipe}</span>
                </p>
                <p>
                  Actual step : <span className='font-bold text-secondary text-xl'>{data.actualStep} </span>
                </p>
              </div>
              {/* Last round  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Last round</h2>
                <p>
                  Cycle time : <span className='font-bold text-secondary text-xl'>{data.cycleTime} sec</span>
                </p>
                <p>
                  Folding time : <span className='font-bold text-secondary text-xl'>{data.foldingTime} sec</span>
                </p>
                <p>
                  Set max folding time : <span className='font-bold text-secondary text-xl'>{data.foldingSetPointMax} sec</span>
                </p>
                <p>
                  Heating time : <span className='font-bold text-secondary text-xl'>{data.heatingTime} sec</span>
                </p>
                <p>
                  Set max heating time : <span className='font-bold text-secondary text-xl'>{data.heatingSetPointMax} sec</span>
                </p>
                <p>
                  Temp left down : <span className='font-bold text-secondary text-xl'>{data.tempLeftDown} &deg;C</span>
                </p>
                <p>
                  Temp left up : <span className='font-bold text-secondary text-xl'>{data.tempLeftUp} &deg;C</span>
                </p>
                <p>
                  Temp right down : <span className='font-bold text-secondary text-xl'>{data.tempRightDown} &deg;C</span>
                </p>
                <p>
                  Temp right up : <span className='font-bold text-secondary text-xl'>{data.tempRightUp} &deg;C</span>
                </p>
                <p>
                  Pyrometer on :<span className='font-bold text-secondary text-xl'>{data.pyroIndicatorOnOff ? 'yes' : 'no'}</span>
                </p>
                <p>
                  Date last shot : <span className='font-bold text-secondary text-xl'>{data.shotDateTime}</span>
                </p>
              </div>
              {/*  */}
            </div>
          </div>
        </div>
        {/*  */}
      </div>
    </div>
  )
}
export default OpelArmrestFront
