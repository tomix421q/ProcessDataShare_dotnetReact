import axios from 'axios'
import { useState, useEffect } from 'react'
import { RiSignalWifiErrorFill } from 'react-icons/ri'
import { LiaInfoCircleSolid } from 'react-icons/lia'
import { IoMdClose } from 'react-icons/io'
//load config
import loadConfig from '../../../loadConfig'
const config = loadConfig()

const url = `http://${config.apiBaseUrl}:5147/api/asqmachines/asq4`

const Asq4Live = () => {
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
              <h1 className='text-4xl md:text-8xl text-collor2 font-thin font-extraFont rounded-lg py-2'>ASQ 4</h1>
              <h4 className='text-sm md:text-lg mb-2 uppercase flex justify-center flex-col md:flex-row md:gap-x-10'>
                <div>
                  ROBOT A :
                  <span className='text-secondary'>
                    {data.roB1_Downtime_Time == 0 ? ' InProduction' : ' Downtime: ' + data.roB1_Downtime_Time + ' min'}
                  </span>
                </div>
                <div>
                  ROBOT B :
                  <span className='text-secondary'>
                    {data.roB2_Downtime_Time == 0 ? ' InProduction' : ' Downtime: ' + data.roB2_Downtime_Time + ' min'}
                  </span>
                </div>
              </h4>
            </div>
            {/* body  */}
            <div className='flex flex-col lg:flex-row my-8 gap-y-4 justify-between'>
              {/* Global  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Global</h2>
                <p>
                  Ref value : <span className='font-bold text-secondary text-xl'>{data.global_RefValue} g</span>
                </p>
                <p>
                  Weight tol. minus : <span className='font-bold text-secondary text-xl'>{data.global_WeightTolMinus} g</span>
                </p>
                <p>
                  Weight tol. plus : <span className='font-bold text-secondary text-xl'>{data.global_WeightTolPlus} g</span>
                </p>
                <p>
                  Go weight after : <span className='font-bold text-secondary text-xl'>{data.global_GoWeightAfter}</span>
                </p>
                <p>
                  Mixing time : <span className='font-bold text-secondary text-xl'>{data.global_MixingTime} </span>
                </p>
              </div>
              {/* Rob A  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Robot A</h2>
                <p>
                  Form number : <span className='font-bold text-secondary text-xl'>{data.roB1_FormNumber}</span>
                </p>
                <p>
                  Actual weight : <span className='font-bold text-secondary text-xl'>{data.roB1_WeightActualValue} g</span>
                </p>
                <p>
                  Set temperature : <span className='font-bold text-secondary text-xl'>{data.roB1_SetTemperature} &deg;C </span>
                </p>
                <p>
                  Actual temperature : <span className='font-bold text-secondary text-xl'>{data.roB1_Temperature} &deg;C</span>
                </p>
                <p>
                  Time drying : <span className='font-bold text-secondary text-xl'>{data.roB1_TimeDrying}</span>
                </p>
              </div>
              {/* Robot  */}
              <div className='leading-relaxed border-collor1 border p-6 shadow-2xl shadow-black rounded-lg hover:scale-105 ease-in duration-200 min-w-[28%] bg-gray-800'>
                <h2 className='text-2xl md:text-4xl text-collor1 uppercase border-b border-dashed border-collor1'>Robot B</h2>
                <p>
                  Form number : <span className='font-bold text-secondary text-xl'>{data.roB2_FormNumber}</span>
                </p>
                <p>
                  Actual weight : <span className='font-bold text-secondary text-xl'>{data.roB2_WeightActualValue} g</span>
                </p>
                <p>
                  Set temperature : <span className='font-bold text-secondary text-xl'>{data.roB2_SetTemperature} &deg;C </span>
                </p>
                <p>
                  Actual temperature : <span className='font-bold text-secondary text-xl'>{data.roB2_Temperature} &deg;C</span>
                </p>
                <p>
                  Time drying : <span className='font-bold text-secondary text-xl'>{data.roB2_TimeDrying}</span>
                </p>
              </div>
            </div>
            {/*  */}
            {/* FORM LIST */}
            <button
              onClick={() => setShowPicture(!showPicture)}
              title='Open form list'
              className='btn btn-sm md:btn-lg md:btn-lg uppercase'
            >
              <span className='centerBtn'>
                Form List
                <LiaInfoCircleSolid className={`size-7 ml-2`}></LiaInfoCircleSolid>
              </span>
            </button>

            <button
              onClick={() => setShowPicture(!showPicture)}
              className={`${showPicture === true ? 'fixed bg-black w-full h-full  z-40 top-0 left-0' : 'hidden'}  `}
            >
              <IoMdClose className='size-14 left-0 top-0 text-collor2 absolute m-4' />
              <div className='top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 p-5 absolute'>
                <img className={`min-w-[280px]`} src='/machinePicture/asq_FrmNumbers.jpg' alt='image form list' />
              </div>
            </button>
          </div>
        </div>
        {/*  */}
      </div>
    </div>
  )
}
export default Asq4Live
